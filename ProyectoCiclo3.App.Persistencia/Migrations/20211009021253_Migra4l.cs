using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class Migra4l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Encomiendas",
                table: "Encomiendas");

            migrationBuilder.RenameTable(
                name: "Encomiendas",
                newName: "Encomienda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encomienda",
                table: "Encomienda",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Encomienda",
                table: "Encomienda");

            migrationBuilder.RenameTable(
                name: "Encomienda",
                newName: "Encomiendas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Encomiendas",
                table: "Encomiendas",
                column: "id");
        }
    }
}
