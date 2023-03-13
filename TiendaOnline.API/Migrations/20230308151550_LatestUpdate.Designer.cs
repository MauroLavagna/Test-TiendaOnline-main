﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiendaOnline.API.Data;

#nullable disable

namespace TiendaOnline.API.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    [Migration("20230308151550_LatestUpdate")]
    partial class LatestUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TiendaOnline.API.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("TiendaOnline.API.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("TiendaOnline.API.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Curso de C",
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Name = "Primer curso C",
                            Price = 100m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Curso de C",
                            ImageURL = "/Images/Beauty/Beauty2.png",
                            Name = "Segundo curso C 2023",
                            Price = 50m,
                            Qty = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Curso de C",
                            ImageURL = "/Images/Beauty/Beauty3.png",
                            Name = "Tercer curso C",
                            Price = 20m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Curso de C",
                            ImageURL = "/Images/Beauty/Beauty4.png",
                            Name = "Cuarto curso C",
                            Price = 50m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Curso de C",
                            ImageURL = "/Images/Beauty/Beauty5.png",
                            Name = "Quinto Curso C",
                            Price = 30m,
                            Qty = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Curso de Blazor",
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Name = "Primer curso Blazor",
                            Price = 100m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Curso de Blazor",
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Name = "Segundo curso Blazor",
                            Price = 40m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Curso de Blazor",
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Name = "Tercer curso Blazor",
                            Price = 40m,
                            Qty = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Curso de Blazor",
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Name = "Cuarto curso Blazor",
                            Price = 600m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Curso de Blazor",
                            ImageURL = "/Images/Electronic/Electronic5.png",
                            Name = "Quinto curso Blazor",
                            Price = 500m,
                            Qty = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Curso de Blazor",
                            ImageURL = "/Images/Electronic/technology6.png",
                            Name = "Sexto curso Blazor",
                            Price = 100m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Curso de Python",
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Name = "Primer curso Python",
                            Price = 50m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Curso de Python",
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Name = "Segundo curso Python",
                            Price = 50m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Curso de Python",
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Name = "Tercer curso Python",
                            Price = 70m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Curso de Python",
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Name = "Cuarto curso Python",
                            Price = 120m,
                            Qty = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "Curso de Python",
                            ImageURL = "/Images/Furniture/Furniture6.png",
                            Name = "Quinto curso Python",
                            Price = 15m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Curso de Python",
                            ImageURL = "/Images/Furniture/Furniture7.png",
                            Name = "Sexto curso Python",
                            Price = 20m,
                            Qty = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Curso de Chatbot",
                            ImageURL = "/Images/Shoes/Shoes1.png",
                            Name = "Primer curso ChatBot",
                            Price = 100m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Curso de Chatbot",
                            ImageURL = "/Images/Shoes/Shoes2.png",
                            Name = "Tercer curso ChatBot",
                            Price = 150m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Curso de Chatbot",
                            ImageURL = "/Images/Shoes/Shoes3.png",
                            Name = "Cuarto curso ChatBot",
                            Price = 200m,
                            Qty = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Curso de Chatbot",
                            ImageURL = "/Images/Shoes/Shoes4.png",
                            Name = "Quinto curso ChatBot",
                            Price = 120m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Curso de Chatbot",
                            ImageURL = "/Images/Shoes/Shoes5.png",
                            Name = "Sexto curso ChatBot",
                            Price = 200m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Curso de Chatbot",
                            ImageURL = "/Images/Shoes/Shoes6.png",
                            Name = "Septimo curso ChatBot",
                            Price = 50m,
                            Qty = 150
                        });
                });

            modelBuilder.Entity("TiendaOnline.API.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Name = "Curso C"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-couch",
                            Name = "Curso Blazor"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Curso Python"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-shoe-print",
                            Name = "Curso ChatBot"
                        });
                });

            modelBuilder.Entity("TiendaOnline.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Mauro"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Julian"
                        },
                        new
                        {
                            Id = 3,
                            UserName = "Perla"
                        },
                        new
                        {
                            Id = 4,
                            UserName = "Juan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
