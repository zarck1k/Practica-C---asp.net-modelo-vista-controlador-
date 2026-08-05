using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventaMeCF.Migrations
{
    /// <inheritdoc />
    public partial class SeedMarcas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nike" },
                    { 2, "Adidas" },
                    { 3, "Puma" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
