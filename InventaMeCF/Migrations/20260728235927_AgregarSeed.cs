using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventaMeCF.Migrations
{
    /// <inheritdoc />
    public partial class AgregarSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Usuario" }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Clave",
                value: "ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f");

            migrationBuilder.InsertData(
                table: "RolesAsignados",
                columns: new[] { "Id", "RolId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolesAsignados",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RolesAsignados",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Clave",
                value: "1234567890abcdef1234567890abcdef1234567890abcdef1234567890abcdef");
        }
    }
}
