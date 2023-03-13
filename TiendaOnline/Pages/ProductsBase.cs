using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using TiendaOnline.Services.Contracts;
using TiendaOnline.Web.Services.Contracts;

namespace TiendaOnline.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        [Inject]
        public  IShoppingCartService ShoppingCartService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Products = await ProductService.GetItems();

                var shoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserId);
                var totalQty = shoppingCartItems.Sum(i => i.Qty);

                ShoppingCartService.RaiseEventOnShoppingCartChanged(totalQty);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }

    }
}
