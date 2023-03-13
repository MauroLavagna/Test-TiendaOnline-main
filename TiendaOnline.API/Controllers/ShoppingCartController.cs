using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Models.Dtos;
using TiendaOnline.API.Extensions;
using TiendaOnline.API.Repositories.Contracts;

namespace TiendaOnline.API.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository,
                                        IProductRepository productRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
        }
        [HttpGet]
        [Route("{userId}/GetItems")]
        public async Task<ActionResult<IEnumerable<CartItemDto>>> GetItems(int userId)
        { 
            try
            {
                var cartItems = await this.shoppingCartRepository.GetItems(userId);
                if(cartItems == null)
                {
                    return NoContent();
                }
                var products = await this.productRepository.GetItems();

                if(products == null)
                {
                    throw new Exception("No existen productos en el sistema");
                }
                var cartItemsDto = cartItems.ConverToDto(products);
                return Ok(cartItemsDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<CartItemDto>> GetItem(int id)
        {
            try
            {
                var cartItem = await this.shoppingCartRepository.GetItem(id);
                if(cartItem == null)
                {
                    return NotFound();
                }
                var product = await productRepository.GetItem(cartItem.ProductId);
                if(product == null)
                {
                    return NotFound();
                }
                var cartItemDto = cartItem.ConverToDto(product);
                return Ok(cartItemDto);
            }
            catch (Exception ex) 
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

           
        }
        [HttpPost]
        public async Task<ActionResult<CartItemDto>> PostItem([FromBody] CartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var newCartItem = await this.shoppingCartRepository.AddItem(cartItemToAddDto);
                if(newCartItem == null) 
                {
                    return NoContent();
                }
                var product = await productRepository.GetItem(newCartItem.ProductId);
                if(product == null) 
                {
                    throw new Exception($"Algo salio mal al querer recuperar el producto (productId({cartItemToAddDto.ProductId})");
                }
                var newCartItemDto = newCartItem.ConverToDto(product);
                return CreatedAtAction(nameof(GetItem), new { id = newCartItemDto.Id }, newCartItemDto);
            }
            catch (Exception ex) 
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task <ActionResult<CartItemDto>> DeleteItem (int id)
        {
            try
            {
                var cartItem = await this.shoppingCartRepository.DeleteItem(id);
                if(cartItem == null)
                {
                    return NotFound();
                }   
                var product = await this.productRepository.GetItem(cartItem.ProductId);

                if(product == null)
                   return NotFound();
                var cartItemDto = cartItem.ConverToDto(product);

                return Ok(cartItemDto);
                
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
           }

        [HttpPatch("{id:int}")]
        public async Task<ActionResult<CartItemDto>> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            try
            {
                var cartItem = await this.shoppingCartRepository.UpdateQty(id, cartItemQtyUpdateDto);
                if(cartItem == null)
                {
                    return NotFound();
                }
                var product = await productRepository.GetItem(cartItem.ProductId);
                var cartItemDto = cartItem.ConverToDto(product);
                return Ok(cartItemDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
                
            }
        }

    }
}
