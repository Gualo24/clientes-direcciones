using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class dbinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Apellidos = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Telefono = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Eliminado = table.Column<bool>(type: "BIT", nullable: false, defaultValue: false),
                    FechaEliminado = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    IdProvincia = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinciaNombre = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.IdProvincia);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    IdMunicipio = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProvincia = table.Column<int>(type: "INT", nullable: false),
                    MunicipioNombre = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.IdMunicipio);
                    table.ForeignKey(
                        name: "FK_Municipios_Provincias_IdProvincia",
                        column: x => x.IdProvincia,
                        principalTable: "Provincias",
                        principalColumn: "IdProvincia");
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    IdDireccion = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "INT", nullable: false),
                    IdProvincia = table.Column<int>(type: "INT", nullable: false),
                    IdMunicipio = table.Column<int>(type: "INT", nullable: false),
                    Referencia = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Detalle = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    Georeferencia = table.Column<string>(type: "VARCHAR(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.IdDireccion);
                    table.ForeignKey(
                        name: "FK_Direcciones_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente");
                    table.ForeignKey(
                        name: "FK_Direcciones_Municipios_IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "Municipios",
                        principalColumn: "IdMunicipio");
                    table.ForeignKey(
                        name: "FK_Direcciones_Provincias_IdProvincia",
                        column: x => x.IdProvincia,
                        principalTable: "Provincias",
                        principalColumn: "IdProvincia");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_IdCliente",
                table: "Direcciones",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_IdMunicipio",
                table: "Direcciones",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_IdProvincia",
                table: "Direcciones",
                column: "IdProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_IdProvincia",
                table: "Municipios",
                column: "IdProvincia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Provincias");
        }
    }
}
