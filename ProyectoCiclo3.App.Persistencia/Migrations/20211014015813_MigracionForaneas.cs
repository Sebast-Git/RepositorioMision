using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class MigracionForaneas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "destino",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "encomienda",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "origen",
                table: "Servicio");

            migrationBuilder.AddColumn<int>(
                name: "destinoid",
                table: "Servicio",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "encomiendaid",
                table: "Servicio",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "origenid",
                table: "Servicio",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_destinoid",
                table: "Servicio",
                column: "destinoid");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_encomiendaid",
                table: "Servicio",
                column: "encomiendaid");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_origenid",
                table: "Servicio",
                column: "origenid");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Encomienda_encomiendaid",
                table: "Servicio",
                column: "encomiendaid",
                principalTable: "Encomienda",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Usuario_destinoid",
                table: "Servicio",
                column: "destinoid",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Usuario_origenid",
                table: "Servicio",
                column: "origenid",
                principalTable: "Usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Encomienda_encomiendaid",
                table: "Servicio");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Usuario_destinoid",
                table: "Servicio");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Usuario_origenid",
                table: "Servicio");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_destinoid",
                table: "Servicio");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_encomiendaid",
                table: "Servicio");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_origenid",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "destinoid",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "encomiendaid",
                table: "Servicio");

            migrationBuilder.DropColumn(
                name: "origenid",
                table: "Servicio");

            migrationBuilder.AddColumn<string>(
                name: "destino",
                table: "Servicio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "encomienda",
                table: "Servicio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "origen",
                table: "Servicio",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
