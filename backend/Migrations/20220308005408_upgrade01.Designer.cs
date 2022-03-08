﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Context;

namespace backend.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220308005408_upgrade01")]
    partial class upgrade01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backend.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<bool>("Eliminado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("FechaEliminado")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("backend.Models.Direccion", b =>
                {
                    b.Property<int>("IdDireccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<bool>("Eliminado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("FechaEliminado")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Georeferencia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("INT");

                    b.Property<int>("IdMunicipio")
                        .HasColumnType("INT");

                    b.Property<int>("IdProvincia")
                        .HasColumnType("INT");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("IdDireccion");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdMunicipio");

                    b.HasIndex("IdProvincia");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("backend.Models.Municipio", b =>
                {
                    b.Property<int>("IdMunicipio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProvincia")
                        .HasColumnType("INT");

                    b.Property<string>("MunicipioNombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("IdMunicipio");

                    b.HasIndex("IdProvincia");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("backend.Models.Provincia", b =>
                {
                    b.Property<int>("IdProvincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProvinciaNombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("IdProvincia");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("backend.Models.Direccion", b =>
                {
                    b.HasOne("backend.Models.Cliente", "Cliente")
                        .WithMany("Direcciones")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("backend.Models.Municipio", "Municipio")
                        .WithMany("Direcciones")
                        .HasForeignKey("IdMunicipio")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("backend.Models.Provincia", "Provincia")
                        .WithMany("Direcciones")
                        .HasForeignKey("IdProvincia")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Municipio");

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("backend.Models.Municipio", b =>
                {
                    b.HasOne("backend.Models.Provincia", "Provincia")
                        .WithMany("Municipios")
                        .HasForeignKey("IdProvincia")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Provincia");
                });

            modelBuilder.Entity("backend.Models.Cliente", b =>
                {
                    b.Navigation("Direcciones");
                });

            modelBuilder.Entity("backend.Models.Municipio", b =>
                {
                    b.Navigation("Direcciones");
                });

            modelBuilder.Entity("backend.Models.Provincia", b =>
                {
                    b.Navigation("Direcciones");

                    b.Navigation("Municipios");
                });
#pragma warning restore 612, 618
        }
    }
}