using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "Description", "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/11_mars.jpg", "Camiseta_OccupeMars", "69,9" },
                    { 3L, "Tools", "Description", "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Millenium Falcom", "469,9" },
                    { 4L, "T-shirt", "Description", "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta Gnu Linux", "69,9" },
                    { 5L, "T-shirt", "Description", "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/13_dragon_ball.jpg?raw=true", "Camiseta Dragon Ball", "59,9" },
                    { 6L, "Tools", "Description", "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/14_patch_nasa.jpg?raw=true", "Patch Nasa", "29,9" },
                    { 7L, "Tools", "Description", "https://github.com/Bethania-Freitas/erudio-microsservices/blob/main/ShoppingImages/1_super_mario.jpg?raw=true", "Caneca Mario", "29,9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);
        }
    }
}
