using Newtonsoft.Json;
using ShopOnline.Models.Dtos;
using System.Net.Http.Json;
using System.Text;
using TiendaOnline.Services.Contracts;

namespace TiendaOnline.Services
{
    public class ShoppingCartService : IShoppingCartService

    {
        private readonly HttpClient httpClient;

        public event Action<int> OnShoppingCartChanged;
        Task<IEnumerable<CartItemDto>> IShoppingCartService.GetItems(int userId)
        {
            throw new NotImplementedException();
        }
        


        public ShoppingCartService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }   
        async Task<CartItemDto> IShoppingCartService.AddItem(CartItemToAddDto cartItemAddDto)
        {
            try
                {
                var response = await httpClient.PostAsJsonAsync<CartItemToAddDto>("api/ShoppingCart", cartItemAddDto);
                if (response.IsSuccessStatusCode)
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(CartItemDto);
                    }
                    return await response.Content.ReadFromJsonAsync<CartItemDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Estatus Http:{response.StatusCode} Mensaje {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        async Task<CartItemDto> IShoppingCartService.DeleteItem(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"api/ShoppingCart/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CartItemDto>();
                }
                return default(CartItemDto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CartItemDto>> GetItems(int userId)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/ShoppingCart/{userId}/GetItems");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<CartItemDto>().ToList();
                    }
                    return await response.Content.ReadFromJsonAsync<List<CartItemDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Mensaje estado Htpp: {response.StatusCode} Mensaje: {message}");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<CartItemDto> UpdateQty(CartItemQtyUpdateDto cartItemQtyUpdate)
        {
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(cartItemQtyUpdate);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json-patch+json");
                var response = await httpClient.PatchAsync($"api/ShoppingCart/{cartItemQtyUpdate.CartId}", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CartItemDto>();
                }
                return null;
            }
            catch (Exception)
            {
                throw;
                
            }
        }

        public void RaiseEventOnShoppingCartChanged(int totalQty)
        {
            if(OnShoppingCartChanged != null)
            {
                OnShoppingCartChanged.Invoke(totalQty);
            }
        }
    }
}
