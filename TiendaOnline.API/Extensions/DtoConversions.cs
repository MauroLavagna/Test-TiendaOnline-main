﻿using ShopOnline.Models.Dtos;
using TiendaOnline.API.Entities;


namespace TiendaOnline.API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products,
                                                            IEnumerable<ProductCategory> productCategories)
        {
            return (from product in products
                    join productCategory in productCategories
                    on product.CategoryId equals productCategory.Id
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Qty = product.Qty,
                        CategoryId = product.CategoryId,

                    }).ToList();

        }
        public static ProductDto ConvertToDto(this Product product,
                                                           ProductCategory productCategory)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageURL = product.ImageURL,
                Price = product.Price,
                Qty = product.Qty,
                CategoryId = product.CategoryId,
                CategoryName = productCategory.Name
            };

        }

        public static IEnumerable<CartItemDto> ConverToDto(this IEnumerable<CartItem> cartItems, IEnumerable<Product> products)
        {
            return (from cartItem in cartItems
                    join product in products
                    on cartItem.ProductId equals product.Id
                    select new CartItemDto
                    {
                        Id = cartItem.Id,
                        ProductId = cartItem.ProductId,
                        ProductName = product.Name,
                        ProductDescription = product.Description,
                        ProductImageURL = product.ImageURL,
                        Price = (int)product.Price,
                        CartId = cartItem.CartId,
                        Qty = cartItem.Qty,
                        TotalPrice = (int)(product.Price * cartItem.Qty)
                    }).ToList();  
        }

        public static CartItemDto ConverToDto(this CartItem cartItem, Product product)
        {
            
                return new CartItemDto
                     {
                         Id = cartItem.Id,
                         ProductId = cartItem.ProductId,
                         ProductName = product.Name,
                         ProductDescription = product.Description,
                         ProductImageURL = product.ImageURL,
                         Price = (int)product.Price,
                         CartId = cartItem.CartId,
                         Qty = cartItem.Qty,
                         TotalPrice = (int)product.Price * cartItem.Qty
                     };
        }
    }
}