using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaOnline.API.Repositories.Contracts;
using ShopOnline.Models.Dtos;
using TiendaOnline.API.Extensions;

namespace TiendaOnline.API.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetItems()
        {
            try
            {
                var products = await this.productRepository.GetItems();
                var productCategories = await this.productRepository.GetCategories();

                if (products == null || productCategories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productsDtos = products.ConvertToDto(productCategories);
                    return Ok(productsDtos);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data");
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetItem(int id)
        {
            try
            {
                var product = await this.productRepository.GetItem(id);

                if (product == null)
                {
                    return BadRequest();
                }
                else
                {
                    var productCategory = await this.productRepository.GetCategory(product.CategoryId);
                    var productDto = product.ConvertToDto(productCategory);
                    return Ok(productDto);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data");
            }

        }
    }
}
