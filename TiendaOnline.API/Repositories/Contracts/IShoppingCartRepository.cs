using ShopOnline.Models.Dtos;
using TiendaOnline.API.Entities;

namespace TiendaOnline.API.Repositories.Contracts
{
    public interface IShoppingCartRepository
    {
        Task<CartItem> AddItem(CartItemToAddDto cartIteToAddDto);
        Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto);

        Task<CartItem> DeleteItem(int id); //METODOS
        Task<CartItem> GetItem(int id);
        Task<List<CartItem>> GetItems(int userdId);

    }
}
