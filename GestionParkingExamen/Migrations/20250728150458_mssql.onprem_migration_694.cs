using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionParkingExamen.Migrations
{
    /// <inheritdoc />
    public partial class mssqlonprem_migration_694 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_AspNetUsers_IdUsuario",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "FechIni",
                table: "Reservas",
                newName: "fechIni");

            migrationBuilder.RenameColumn(
                name: "FechFin",
                table: "Reservas",
                newName: "fechFin");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Reservas",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "IdReserva",
                table: "Reservas",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Reservas_IdUsuario",
                table: "Reservas",
                newName: "IX_Reservas_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_AspNetUsers_UsuarioId",
                table: "Reservas",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_AspNetUsers_UsuarioId",
                table: "Reservas");

            migrationBuilder.RenameColumn(
                name: "fechIni",
                table: "Reservas",
                newName: "FechIni");

            migrationBuilder.RenameColumn(
                name: "fechFin",
                table: "Reservas",
                newName: "FechFin");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Reservas",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Reservas",
                newName: "IdReserva");

            migrationBuilder.RenameIndex(
                name: "IX_Reservas_UsuarioId",
                table: "Reservas",
                newName: "IX_Reservas_IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_AspNetUsers_IdUsuario",
                table: "Reservas",
                column: "IdUsuario",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
