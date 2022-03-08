using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.ModelsConfigure
{
    public static class DireccionConfigure
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Models.Direccion>()
            .ToTable("Direcciones");

            modelBuilder
          .Entity<Models.Direccion>(entity =>
          {
              entity.HasKey(b => b.IdDireccion);
              entity.Property(b => b.IdDireccion)
                     .UseIdentityColumn()
                     .IsRequired()
                     .HasColumnType("INT");

              entity.Property(b => b.IdCliente)
                    .IsRequired()
                    .HasColumnType("INT");

              entity.Property(b => b.IdProvincia)
                   .IsRequired()
                   .HasColumnType("INT");

              entity.Property(b => b.IdMunicipio)
                   .IsRequired()
                   .HasColumnType("INT");

              entity.Property(b => b.Referencia)
                  .IsRequired()
                  .HasColumnType("VARCHAR(200)");

              entity.Property(b => b.Detalle)
                    .IsRequired()
                    .HasColumnType("VARCHAR(MAX)");

              entity.Property(b => b.Georeferencia)
                    .IsRequired()
                    .HasColumnType("VARCHAR(200)");

              entity.Property(b => b.Eliminado)
                    .IsRequired()
                   .HasColumnType("BIT")
                   .HasDefaultValue(false);

              entity.Property(b => b.FechaEliminado)
                  .HasColumnType("DATETIME");

              //Relaciones
              entity.HasOne(p => p.Cliente)
                     .WithMany(b => b.Direcciones)
                     .HasForeignKey(c => c.IdCliente)
                     .OnDelete(DeleteBehavior.NoAction);

              entity.HasOne(p => p.Provincia)
                     .WithMany(b => b.Direcciones)
                     .HasForeignKey(c => c.IdProvincia)
                     .OnDelete(DeleteBehavior.NoAction);

              entity.HasOne(p => p.Municipio)
                     .WithMany(b => b.Direcciones)
                     .HasForeignKey(c => c.IdMunicipio)
                     .OnDelete(DeleteBehavior.NoAction);
          });
        }
    }
}
