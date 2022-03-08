using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.ModelsConfigure
{
    public static class ClienteConfigure
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Models.Cliente>().ToTable("Clientes");

            modelBuilder
            .Entity<Models.Cliente>(entity =>
            {
              entity.HasKey(b => b.IdCliente);
              entity.Property(b => b.IdCliente)
                   .UseIdentityColumn()
                   .IsRequired()
                   .HasColumnType("INT");

                entity.Property(b => b.Nombres)
                   .IsRequired()
                   .HasColumnType("VARCHAR(200)");

                entity.Property(b => b.Apellidos)
                  .IsRequired()
                  .HasColumnType("VARCHAR(200)");

                entity.Property(b => b.CorreoElectronico)
                    .IsRequired()
                    .HasColumnType("VARCHAR(200)");

                entity.Property(b => b.Telefono)
                 .IsRequired()
                 .HasColumnType("VARCHAR(20)");

                entity.Property(b => b.Eliminado)
                     .IsRequired()
                    .HasColumnType("BIT")
                    .HasDefaultValue(false);

                entity.Property(b => b.FechaEliminado)
                    .HasColumnType("DATETIME");


                //Relaciones
                entity.HasMany(p => p.Direcciones)
                       .WithOne(b => b.Cliente)
                       .HasForeignKey(c => c.IdCliente)
                       .OnDelete(DeleteBehavior.NoAction);

            });
        }
    }
}
