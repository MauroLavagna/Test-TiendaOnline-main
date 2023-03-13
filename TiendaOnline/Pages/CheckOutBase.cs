using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ShopOnline.Models.Dtos;
using TiendaOnline.Services.Contracts;

namespace TiendaOnline.Pages
{
    public class CheckOutBase : ComponentBase
    {
        [Inject]
        public IJSRuntime Js { get; set; }
    
        protected IEnumerable<CartItemDto> ShoppingCartItems { get; set; }
    
        protected int TotalQty { get; set; }

        protected string PaymentDescription { get; set; }

        protected decimal PaymentAmount { get; set; }

        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                ShoppingCartItems = await ShoppingCartService.GetItems(HardCoded.UserId);
                if(ShoppingCartItems != null)
                {
                    Guid orderGuid = Guid.NewGuid();

                    PaymentAmount = ShoppingCartItems.Sum(p => p.TotalPrice);
                    TotalQty = ShoppingCartItems.Sum(p => p.Qty); // ?????
                    PaymentDescription = $"O_{HardCoded.UserId}_{orderGuid}";

                }
            }
            catch (Exception)
            {
                //Excepcion de login
                throw;
            }
            
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            try
            {
                if (firstRender)
                {
                    await Js.InvokeVoidAsync("initPaypalButton");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
