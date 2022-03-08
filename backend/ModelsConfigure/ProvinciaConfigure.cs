using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.ModelsConfigure
{
    public static class ProvinciaConfigure
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder
           .Entity<Models.Provincia>().ToTable("Provincias");

            modelBuilder
           .Entity<Models.Provincia>(entity =>
           {
               entity.HasKey(b => b.IdProvincia);
               entity.Property(b => b.IdProvincia)
                     .IsRequired()
                     .HasColumnType("INT");

               entity.Property(b => b.ProvinciaNombre)
                     .IsRequired()
                     .HasColumnType("VARCHAR(200)");


               //Relaciones
               entity.HasMany(p => p.Municipios)
                       .WithOne(b => b.Provincia)
                       .HasForeignKey(c => c.IdProvincia)
                       .OnDelete(DeleteBehavior.NoAction);

               entity.HasMany(p => p.Direcciones)
                      .WithOne(b => b.Provincia)
                      .HasForeignKey(c => c.IdProvincia)
                      .OnDelete(DeleteBehavior.NoAction);

           });

            modelBuilder.Entity<Models.Provincia>()
                .HasData(new List<Models.Provincia>
                {
                    new Models.Provincia{IdProvincia = 1, ProvinciaNombre = "Azua" },
                    new Models.Provincia{IdProvincia = 2, ProvinciaNombre ="Bahoruco"},
                    new Models.Provincia{IdProvincia = 3, ProvinciaNombre ="Barahona" },
                    new Models.Provincia{IdProvincia = 4, ProvinciaNombre ="Dajabón"},
                    new Models.Provincia{IdProvincia = 5, ProvinciaNombre ="Distrito Nacional"},
                    new Models.Provincia{IdProvincia = 6, ProvinciaNombre ="Duarte"},
                    new Models.Provincia{IdProvincia = 7, ProvinciaNombre ="Elías Piña"},
                    new Models.Provincia{IdProvincia = 8, ProvinciaNombre ="El Seibo"},
                    new Models.Provincia{IdProvincia = 9, ProvinciaNombre ="Espaillat"},
                    new Models.Provincia{IdProvincia = 10,ProvinciaNombre ="Hato Mayor"},
                    new Models.Provincia{IdProvincia = 11,ProvinciaNombre ="Hermanas Mirabal"},
                    new Models.Provincia{IdProvincia = 12,ProvinciaNombre ="Independencia"},
                    new Models.Provincia{IdProvincia = 13,ProvinciaNombre ="La Altagracia"},
                    new Models.Provincia{IdProvincia = 14,ProvinciaNombre ="La Romana"},
                    new Models.Provincia{IdProvincia = 15,ProvinciaNombre ="La Vega"},
                    new Models.Provincia{IdProvincia = 16,ProvinciaNombre ="María Trinidad Sánchez"},
                    new Models.Provincia{IdProvincia = 17,ProvinciaNombre ="Monseñor Nouel"},
                    new Models.Provincia{IdProvincia = 18,ProvinciaNombre ="Monte Cristi"},
                    new Models.Provincia{IdProvincia = 19,ProvinciaNombre ="Monte Plata"},
                    new Models.Provincia{IdProvincia = 20,ProvinciaNombre ="Pedernales"},
                    new Models.Provincia{IdProvincia = 21,ProvinciaNombre ="Peravia"},
                    new Models.Provincia{IdProvincia = 22,ProvinciaNombre ="Puerto Plata"},
                    new Models.Provincia{IdProvincia = 23,ProvinciaNombre ="Samaná"},
                    new Models.Provincia{IdProvincia = 24,ProvinciaNombre ="Sánchez Ramírez"},
                    new Models.Provincia{IdProvincia = 25,ProvinciaNombre ="San Cristóbal"},
                    new Models.Provincia{IdProvincia = 26,ProvinciaNombre ="San José de Ocoa"},
                    new Models.Provincia{IdProvincia = 27,ProvinciaNombre ="San Juan"},
                    new Models.Provincia{IdProvincia = 28,ProvinciaNombre ="San Pedro de Macorís"},
                    new Models.Provincia{IdProvincia = 29,ProvinciaNombre ="Santiago"},
                    new Models.Provincia{IdProvincia = 30,ProvinciaNombre ="Santiago Rodríguez"},
                    new Models.Provincia{IdProvincia = 31,ProvinciaNombre ="Santo Domingo"},
                    new Models.Provincia{IdProvincia = 32,ProvinciaNombre ="Valverde"}
                });

        }
    }
}
