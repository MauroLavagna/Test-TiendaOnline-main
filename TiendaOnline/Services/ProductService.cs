﻿using System;
using ShopOnline.Models.Dtos;
using System.Net.Http.Json;
using TiendaOnline.Web.Services.Contracts;

namespace TiendaOnline.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        public Task<IEnumerable<ProductDto>> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDto> GetItem(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Product/{id}");
                if (response.IsSuccessStatusCode)
                {   
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(ProductDto);
                    }
                    return await response.Content.ReadFromJsonAsync<ProductDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;// Excepcion de log in

            }
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/Product");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProductDto>();
                    }
                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Estado Http: {response.StatusCode} mensaje: {message}");
                }
            }
            catch (Exception)
            {
                //Excepcion login
                throw;

            }
        }

        public Task<IEnumerable<ProductDto>> GetItems(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetItemsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductCategoryDto>> GetProductCategories()
        {
            throw new NotImplementedException();
        }
    }
}
