using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class upgrade01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Direcciones",
                type: "BIT",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEliminado",
                table: "Direcciones",
                type: "DATETIME",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaEliminado",
                table: "Clientes",
                type: "DATETIME",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Direcciones");

            migrationBuilder.DropColumn(
                name: "FechaEliminado",
                table: "Direcciones");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaEliminado",
                table: "Clientes",
                type: "DATETIME",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldNullable: true);
        }
    }
}
