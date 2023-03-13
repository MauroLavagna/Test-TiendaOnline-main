using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;

namespace TiendaOnline.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
