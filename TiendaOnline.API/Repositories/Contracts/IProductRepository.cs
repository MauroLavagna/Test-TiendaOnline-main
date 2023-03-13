using TiendaOnline.API.Entities;
namespace TiendaOnline.API.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItem(int id); //Defino un metodo para un metodo llamado GetItem que contiene un parametro de tipo entero 
        Task<ProductCategory> GetCategory(int id);
    }
}
