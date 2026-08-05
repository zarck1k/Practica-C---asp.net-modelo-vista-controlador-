using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventaMeCF.Migrations
{
    /// <inheritdoc />
    public partial class IngresoUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Clave", "Correo", "Nombre" },
                values: new object[,]
                {
                    { 1, "1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef", "moi@example.com", "Moies Aquio" },
                    { 2, "1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef", "menr@example.com", "Jhonatan Ralu" },
                    { 3, "1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef", "bend2@example.com", "BEnido juares" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Clave", "Correo", "Nombre" },
                values: new object[,]
                {
                    { 4, "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", "mcortez_vasquez@yahoo.com", "miguel" },
                    { 5, "6bab3007f56e2a9175ff1222c2654ddcd08fa7981a1ddc42f1d95cfbd80ede47", "andrea@gmail.com", "andrea" },
                    { 6, "a29bb351ab7025926eb34a77f0485a0f8ab9dc993009f990cbd8eabbf0d947e3", "daniel@gmail.com", "daniel" }
                });
        }
    }
}
