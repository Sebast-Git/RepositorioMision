using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class Migra3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "Servicio",
                newName: "origen");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Servicio",
                newName: "hora");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Servicio",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "apellidos",
                table: "Servicio",
                newName: "encomienda");

            migrationBuilder.AddColumn<string>(
                name: "ciudad",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "destino",
                table: "Servicio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "peso",
                table: "Encomiendas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ciudad",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "destino",
                table: "Servicio");

            migrationBuilder.RenameColumn(
                name: "origen",
                table: "Servicio",
                newName: "telefono");

            migrationBuilder.RenameColumn(
                name: "hora",
                table: "Servicio",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Servicio",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "encomienda",
                table: "Servicio",
                newName: "apellidos");

            migrationBuilder.AlterColumn<int>(
                name: "peso",
                table: "Encomiendas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
