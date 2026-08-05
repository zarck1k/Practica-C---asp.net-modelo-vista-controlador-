using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InventaMeCF.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesAAA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuarios",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Usuarios",
                type: "varchar(64)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolesAsignados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false),
                    RolId = table.Column<int>(type: "integer", nullable: false),
                    RolId1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesAsignados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolesAsignados_Roles_RolId1",
                        column: x => x.RolId1,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolesAsignados_Usuarios_RolId",
                        column: x => x.RolId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RolesAsignados_RolId",
                table: "RolesAsignados",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_RolesAsignados_RolId1",
                table: "RolesAsignados",
                column: "RolId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolesAsignados");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Usuarios",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Usuarios",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Usuarios",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(64)");
        }
    }
}
