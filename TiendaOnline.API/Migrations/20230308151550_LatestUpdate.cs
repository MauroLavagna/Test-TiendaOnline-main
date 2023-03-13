using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaOnline.API.Migrations
{
    public partial class LatestUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconCSS",
                value: "fas fa-spa");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-couch", "Curso Blazor" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-headphones", "Curso Python" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-shoe-print", "Curso ChatBot" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Curso de C");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Curso de C");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Curso de C");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Curso de C");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Curso de C");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Blazor", "Primer curso Blazor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Blazor", "Segundo curso Blazor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Blazor", "Tercer curso Blazor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Blazor", "Cuarto curso Blazor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Blazor", "Quinto curso Blazor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Blazor", "Sexto curso Blazor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Python", "Primer curso Python" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Python", "Segundo curso Python" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Python", "Tercer curso Python" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Python", "Cuarto curso Python" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Python", "Quinto curso Python" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Python", "Sexto curso Python" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Chatbot", "Primer curso ChatBot" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Chatbot", "Tercer curso ChatBot" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Chatbot", "Cuarto curso ChatBot" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Chatbot", "Quinto curso ChatBot" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Chatbot", "Sexto curso ChatBot" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Curso de Chatbot", "Septimo curso ChatBot" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconCSS",
                value: "test cambio");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "test cambio", "Furniture" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "test cambio", "Electronics" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "test cambio", "Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "test cambios");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "test cambio");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A kit provided by Curology, containing skin care products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "A kit provided by Schwarzkopf, containing skin care and hair care products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Skin Care Kit, containing skin care and hair care products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Air Pods - in-ear wireless headphones", "Air Pods" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "On-ear Golden Headphones - these headphones are not wireless", "On-ear Golden Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name" },
                values: new object[] { "On-ear Black Headphones - these headphones are not wireless", "On-ear Black Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "Sennheiser Digital Camera with Tripod" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Canon Digital Camera - High quality digital camera provided by Canon", "Canon Digital Camera" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Gameboy - Provided by Nintendo", "Nintendo Gameboy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable black leather office chair", "Black Leather Office Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable pink leather office chair", "Pink Leather Office Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable lounge chair", "Lounge Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Very comfortable Silver lounge chair", "Silver Lounge Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name" },
                values: new object[] { "White and blue Porcelain Table Lamp", "Porcelain Table Lamp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Office Table Lamp", "Office Table Lamp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Comfortable Puma Sneakers in most sizes", "Puma Sneakers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Colorful trainsers - available in most sizes", "Colorful Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Blue Nike Trainers - available in most sizes", "Blue Nike Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Colorful Hummel Trainers - available in most sizes", "Colorful Hummel Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Red Nike Trainers - available in most sizes", "Red Nike Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Birkenstock Sandles - available in most sizes", "Birkenstock Sandles" });
        }
    }
}
