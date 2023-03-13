using ShopOnline.Models.Dtos;

namespace TiendaOnline.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
        Task<ProductDto> GetItem(int id);
        Task<IEnumerable<ProductCategoryDto>> GetProductCategories();
        Task<IEnumerable<ProductDto>> GetItemsByCategory(int categoryId);
        Task<IEnumerable<ProductDto>> GetItems(int userId);
        Task <IEnumerable<ProductDto>> DeleteItem(int id);
    }
}
