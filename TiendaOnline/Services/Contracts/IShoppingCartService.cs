using ShopOnline.Models.Dtos;

namespace TiendaOnline.Services.Contracts
{
    public interface IShoppingCartService 
    {
        Task<IEnumerable<CartItemDto>> GetItems(int userId);

        Task<CartItemDto> AddItem(CartItemToAddDto cartItemAddDto);

        Task<CartItemDto> DeleteItem(int id);

        Task<CartItemDto> UpdateQty(CartItemQtyUpdateDto cartItemQtyUpdateDto);

        event Action<int> OnShoppingCartChanged;
        void RaiseEventOnShoppingCartChanged(int TotalQty);
    }
}
