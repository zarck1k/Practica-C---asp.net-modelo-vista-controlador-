using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventaMeCF.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnPrecioUnitario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUnitario",
                table: "Productos",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioUnitario",
                table: "Productos");
        }
    }
}
