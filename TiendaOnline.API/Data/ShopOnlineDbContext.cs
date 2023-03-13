using Microsoft.EntityFrameworkCore;
using TiendaOnline.API.Entities;

namespace TiendaOnline.API.Data
{
	public class ShopOnlineDbContext : DbContext
	{
		public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//Products
			//Beauty Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 1,
				Name = "Primer curso C",
				Description = "Curso de C",
				ImageURL = "/Images/Beauty/Beauty1.png",
				Price = 100,
				Qty = 100,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 2,
				Name = "Segundo curso C 2023",
				Description = "Curso de C",
				ImageURL = "/Images/Beauty/Beauty2.png",
				Price = 50,
				Qty = 45,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 3,
				Name = "Tercer curso C",
				Description = "Curso de C",
				ImageURL = "/Images/Beauty/Beauty3.png",
				Price = 20,
				Qty = 30,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 4,
				Name = "Cuarto curso C",
				Description = "Curso de C",
				ImageURL = "/Images/Beauty/Beauty4.png",
				Price = 50,
				Qty = 60,
				CategoryId = 1

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 5,
				Name = "Quinto Curso C",
				Description = "Curso de C",
				ImageURL = "/Images/Beauty/Beauty5.png",
				Price = 30,
				Qty = 85,
				CategoryId = 1

			});
			//Electronics Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 6,
				Name = "Primer curso Blazor",
				Description = "Curso de Blazor",
				ImageURL = "/Images/Electronic/Electronics1.png",
				Price = 100,
				Qty = 120,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 7,
				Name = "Segundo curso Blazor",
				Description = "Curso de Blazor",
				ImageURL = "/Images/Electronic/Electronics2.png",
				Price = 40,
				Qty = 200,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 8,
				Name = "Tercer curso Blazor",
				Description = "Curso de Blazor",
				ImageURL = "/Images/Electronic/Electronics3.png",
				Price = 40,
				Qty = 300,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 9,
				Name = "Cuarto curso Blazor",
				Description = "Curso de Blazor",
				ImageURL = "/Images/Electronic/Electronic4.png",
				Price = 600,
				Qty = 20,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 10,
				Name = "Quinto curso Blazor",
				Description = "Curso de Blazor",
				ImageURL = "/Images/Electronic/Electronic5.png",
				Price = 500,
				Qty = 15,
				CategoryId = 3

			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 11,
				Name = "Sexto curso Blazor",
				Description = "Curso de Blazor",
				ImageURL = "/Images/Electronic/technology6.png",
				Price = 100,
				Qty = 60,
				CategoryId = 3
			});
			//Furniture Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 12,
				Name = "Primer curso Python",
				Description = "Curso de Python",
				ImageURL = "/Images/Furniture/Furniture1.png",
				Price = 50,
				Qty = 212,
				CategoryId = 2
			});

			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 13,
				Name = "Segundo curso Python",
				Description = "Curso de Python",
				ImageURL = "/Images/Furniture/Furniture2.png",
				Price = 50,
				Qty = 112,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 14,
				Name = "Tercer curso Python",
				Description = "Curso de Python",
				ImageURL = "/Images/Furniture/Furniture3.png",
				Price = 70,
				Qty = 90,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 15,
				Name = "Cuarto curso Python",
				Description = "Curso de Python",
				ImageURL = "/Images/Furniture/Furniture4.png",
				Price = 120,
				Qty = 95,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 16,
				Name = "Quinto curso Python",
				Description = "Curso de Python",
				ImageURL = "/Images/Furniture/Furniture6.png",
				Price = 15,
				Qty = 100,
				CategoryId = 2
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 17,
				Name = "Sexto curso Python",
				Description = "Curso de Python",
				ImageURL = "/Images/Furniture/Furniture7.png",
				Price = 20,
				Qty = 73,
				CategoryId = 2
			});
			//Shoes Category
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 18,
				Name = "Primer curso ChatBot",
				Description = "Curso de Chatbot",
				ImageURL = "/Images/Shoes/Shoes1.png",
				Price = 100,
				Qty = 50,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 19,
				Name = "Tercer curso ChatBot",
				Description = "Curso de Chatbot",
				ImageURL = "/Images/Shoes/Shoes2.png",
				Price = 150,
				Qty = 60,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 20,
				Name = "Cuarto curso ChatBot",
				Description = "Curso de Chatbot",
				ImageURL = "/Images/Shoes/Shoes3.png",
				Price = 200,
				Qty = 70,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 21,
				Name = "Quinto curso ChatBot",
				Description = "Curso de Chatbot",
				ImageURL = "/Images/Shoes/Shoes4.png",
				Price = 120,
				Qty = 120,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 22,
				Name = "Sexto curso ChatBot",
				Description = "Curso de Chatbot",
				ImageURL = "/Images/Shoes/Shoes5.png",
				Price = 200,
				Qty = 100,
				CategoryId = 4
			});
			modelBuilder.Entity<Product>().HasData(new Product
			{
				Id = 23,
				Name = "Septimo curso ChatBot",
				Description = "Curso de Chatbot",
				ImageURL = "/Images/Shoes/Shoes6.png",
				Price = 50,
				Qty = 150,
				CategoryId = 4
			});

			//Add users
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				UserName = "Mauro"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 2,
				UserName = "Julian"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 3,
				UserName = "Perla"

			});
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 4,
				UserName = "Juan"

			});

			//Create Shopping Cart for Users
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 1,
				UserId = 1

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 2,
				UserId = 2

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 3,
				UserId = 3

			});
			modelBuilder.Entity<Cart>().HasData(new Cart
			{
				Id = 4,
				UserId = 4

			});
			//Add Product Categories
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 1,
				Name = "Curso C",
				IconCSS = "fas fa-spa"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 2,
				Name = "Curso Blazor",
				IconCSS = "fas fa-couch"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 3,
				Name = "Curso Python",
				IconCSS = "fas fa-headphones"
			});
			modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
			{
				Id = 4,
				Name = "Curso ChatBot",
				IconCSS = "fas fa-shoe-print"
			});


		}

		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<User> Users { get; set; }

	}
}