using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventaMeCF.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesAAAA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesAsignados_Roles_RolId1",
                table: "RolesAsignados");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesAsignados_Usuarios_RolId",
                table: "RolesAsignados");

            migrationBuilder.DropIndex(
                name: "IX_RolesAsignados_RolId1",
                table: "RolesAsignados");

            migrationBuilder.DropColumn(
                name: "RolId1",
                table: "RolesAsignados");

            migrationBuilder.CreateIndex(
                name: "IX_RolesAsignados_UsuarioId",
                table: "RolesAsignados",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesAsignados_Roles_RolId",
                table: "RolesAsignados",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesAsignados_Usuarios_UsuarioId",
                table: "RolesAsignados",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolesAsignados_Roles_RolId",
                table: "RolesAsignados");

            migrationBuilder.DropForeignKey(
                name: "FK_RolesAsignados_Usuarios_UsuarioId",
                table: "RolesAsignados");

            migrationBuilder.DropIndex(
                name: "IX_RolesAsignados_UsuarioId",
                table: "RolesAsignados");

            migrationBuilder.AddColumn<int>(
                name: "RolId1",
                table: "RolesAsignados",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RolesAsignados_RolId1",
                table: "RolesAsignados",
                column: "RolId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RolesAsignados_Roles_RolId1",
                table: "RolesAsignados",
                column: "RolId1",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolesAsignados_Usuarios_RolId",
                table: "RolesAsignados",
                column: "RolId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
