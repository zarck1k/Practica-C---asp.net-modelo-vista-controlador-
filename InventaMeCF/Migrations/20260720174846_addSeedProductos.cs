using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventaMeCF.Migrations
{
    /// <inheritdoc />
    public partial class addSeedProductos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Descripcion", "MarcaId", "Nombre", "PrecioUnitario" },
                values: new object[,]
                {
                    { 1, "Tenis deportivos para uso diario.", 1, "Nike Air Max 90", 120.00m },
                    { 2, "Calzado ligero para correr.", 1, "Nike Revolution 7", 85.50m },
                    { 3, "Tenis deportivos con gran comodidad.", 2, "Adidas Ultraboost", 180.00m },
                    { 4, "Zapatos para fútbol.", 2, "Adidas Predator", 95.99m },
                    { 5, "Tenis casuales unisex.", 3, "Puma Smash V2", 70.00m },
                    { 6, "Calzado deportivo moderno.", 3, "Puma Future Rider", 110.75m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
