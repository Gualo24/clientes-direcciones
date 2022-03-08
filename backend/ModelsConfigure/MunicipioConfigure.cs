using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.ModelsConfigure
{
    public static class MunicipioConfigure
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder
           .Entity<Models.Municipio>().ToTable("Municipios");

            modelBuilder
         .Entity<Models.Municipio>(entity =>
         {
             entity.HasKey(b => b.IdMunicipio);
             entity.Property(b => b.IdMunicipio)
                   .IsRequired()
                   .HasColumnType("INT");

             entity.Property(b => b.MunicipioNombre)
                   .IsRequired()
                   .HasColumnType("VARCHAR(200)");

             entity.Property(b => b.IdProvincia)
                   .IsRequired()
                   .HasColumnType("INT");


             //Relaciones
             entity.HasOne(p => p.Provincia)
                       .WithMany(b => b.Municipios)
                       .HasForeignKey(c => c.IdProvincia)
                       .OnDelete(DeleteBehavior.NoAction);

             entity.HasMany(p => p.Direcciones)
                     .WithOne(b => b.Municipio)
                     .HasForeignKey(c => c.IdMunicipio)
                     .OnDelete(DeleteBehavior.NoAction);

         });

            modelBuilder.Entity<Models.Municipio>()
               .HasData(new List<Models.Municipio>
               {
                  new Models.Municipio{ IdMunicipio = 1,  MunicipioNombre = "Distrito Nacional", IdProvincia = 5},
                new Models.Municipio{ IdMunicipio = 2,  MunicipioNombre = "Azua de Compostela", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 3,  MunicipioNombre = "Estebanía", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 4,  MunicipioNombre = "Guayabal", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 5,  MunicipioNombre = "Las Charcas", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 6,  MunicipioNombre = "Las Yayas de Viajama", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 7,  MunicipioNombre = "Padre Las Casas", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 8,  MunicipioNombre = "Peralta", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 9,  MunicipioNombre = "Pueblo Viejo", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 10, MunicipioNombre = "Sabana Yegua", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 11, MunicipioNombre = "Tábara Arriba", IdProvincia =1},
                new Models.Municipio{ IdMunicipio = 12, MunicipioNombre = "Neiba", IdProvincia =2},
                new Models.Municipio{ IdMunicipio = 13, MunicipioNombre = "Galván", IdProvincia =2},
                new Models.Municipio{ IdMunicipio = 14, MunicipioNombre = "Los Ríos", IdProvincia =2},
                new Models.Municipio{ IdMunicipio = 15, MunicipioNombre = "Tamayo", IdProvincia =2},
                new Models.Municipio{ IdMunicipio = 16, MunicipioNombre = "Villa Jaragua", IdProvincia =2},
                new Models.Municipio{ IdMunicipio = 17, MunicipioNombre = "Barahona", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 18, MunicipioNombre = "Cabral", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 19, MunicipioNombre = "El Peñón", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 20, MunicipioNombre = "Enriquillo", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 21, MunicipioNombre = "Fundación", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 22, MunicipioNombre = "Jaquimeyes", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 23, MunicipioNombre = "La Ciénaga", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 24, MunicipioNombre = "Las Salinas", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 25, MunicipioNombre = "Paraíso", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 26, MunicipioNombre = "Polo", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 27, MunicipioNombre = "Vicente Noble", IdProvincia =3},
                new Models.Municipio{ IdMunicipio = 28, MunicipioNombre = "Dajabón", IdProvincia =4},
                new Models.Municipio{ IdMunicipio = 29, MunicipioNombre = "El Pino", IdProvincia =4},
                new Models.Municipio{ IdMunicipio = 30, MunicipioNombre = "Loma de Cabrera", IdProvincia =4},
                new Models.Municipio{ IdMunicipio = 31, MunicipioNombre = "Partido", IdProvincia =4},
                new Models.Municipio{ IdMunicipio = 32, MunicipioNombre = "Restauración", IdProvincia =4},
                new Models.Municipio{ IdMunicipio = 33, MunicipioNombre = "San Francisco de Macorís", IdProvincia =6},
                new Models.Municipio{ IdMunicipio = 34, MunicipioNombre = "Arenoso", IdProvincia =6},
                new Models.Municipio{ IdMunicipio = 35, MunicipioNombre = "Castillo", IdProvincia =6},
                new Models.Municipio{ IdMunicipio = 36, MunicipioNombre = "Eugenio María de Hostos", IdProvincia =6},
                new Models.Municipio{ IdMunicipio = 37, MunicipioNombre = "Las Guáranas", IdProvincia =6},
                new Models.Municipio{ IdMunicipio = 38, MunicipioNombre = "Pimentel", IdProvincia =6},
                new Models.Municipio{ IdMunicipio = 39, MunicipioNombre = "Villa Riva", IdProvincia =6},
                new Models.Municipio{ IdMunicipio = 40, MunicipioNombre = "El Seibo", IdProvincia =8},
                new Models.Municipio{ IdMunicipio = 41, MunicipioNombre = "Miches", IdProvincia =8},
                new Models.Municipio{ IdMunicipio = 42, MunicipioNombre = "Comendador", IdProvincia =7},
                new Models.Municipio{ IdMunicipio = 43, MunicipioNombre = "Bánica", IdProvincia =7},
                new Models.Municipio{ IdMunicipio = 44, MunicipioNombre = "El Llano", IdProvincia =7},
                new Models.Municipio{ IdMunicipio = 45, MunicipioNombre = "Hondo Valle", IdProvincia =7},
                new Models.Municipio{ IdMunicipio = 46, MunicipioNombre = "Juan Santiago", IdProvincia =7},
                new Models.Municipio{ IdMunicipio = 47, MunicipioNombre = "Pedro Santana", IdProvincia =7},
                new Models.Municipio{ IdMunicipio = 48, MunicipioNombre = "Moca", IdProvincia =9},
                new Models.Municipio{ IdMunicipio = 49, MunicipioNombre = "Cayetano Germosén", IdProvincia =9},
                new Models.Municipio{ IdMunicipio = 50, MunicipioNombre = "Gaspar Hernández", IdProvincia =9},
                new Models.Municipio{ IdMunicipio = 51, MunicipioNombre = "Jamao al Norte", IdProvincia =9},
                new Models.Municipio{ IdMunicipio = 52, MunicipioNombre = "Hato Mayor del Rey", IdProvincia =10},
                new Models.Municipio{ IdMunicipio = 53, MunicipioNombre = "El Valle", IdProvincia =10},
                new Models.Municipio{ IdMunicipio = 54, MunicipioNombre = "Sabana de la Mar", IdProvincia =10},
                new Models.Municipio{ IdMunicipio = 55, MunicipioNombre = "Salcedo", IdProvincia =11},
                new Models.Municipio{ IdMunicipio = 56, MunicipioNombre = "Tenares", IdProvincia =11},
                new Models.Municipio{ IdMunicipio = 57, MunicipioNombre = "Villa Tapia", IdProvincia =11},
                new Models.Municipio{ IdMunicipio = 58, MunicipioNombre = "Jimaní", IdProvincia =12},
                new Models.Municipio{ IdMunicipio = 59, MunicipioNombre = "Cristóbal", IdProvincia =12},
                new Models.Municipio{ IdMunicipio = 60, MunicipioNombre = "Duvergé", IdProvincia =12},
                new Models.Municipio{ IdMunicipio = 61, MunicipioNombre = "La Descubierta", IdProvincia =12},
                new Models.Municipio{ IdMunicipio = 62, MunicipioNombre = "Mella", IdProvincia =12},
                new Models.Municipio{ IdMunicipio = 63, MunicipioNombre = "Postrer Río", IdProvincia =12},
                new Models.Municipio{ IdMunicipio = 64, MunicipioNombre = "Higüey", IdProvincia =13},
                new Models.Municipio{ IdMunicipio = 65, MunicipioNombre = "San Rafael del Yuma", IdProvincia =13},
                new Models.Municipio{ IdMunicipio = 66, MunicipioNombre = "La Romana", IdProvincia =14},
                new Models.Municipio{ IdMunicipio = 67, MunicipioNombre = "Guaymate", IdProvincia =14},
                new Models.Municipio{ IdMunicipio = 68, MunicipioNombre = "Villa Hermosa", IdProvincia =14},
                new Models.Municipio{ IdMunicipio = 69, MunicipioNombre = "La Concepción de La Vega", IdProvincia =15},
                new Models.Municipio{ IdMunicipio = 70, MunicipioNombre = "Constanza", IdProvincia =15},
                new Models.Municipio{ IdMunicipio = 71, MunicipioNombre = "Jarabacoa", IdProvincia =15},
                new Models.Municipio{ IdMunicipio = 72, MunicipioNombre = "Jima Abajo", IdProvincia =15},
                new Models.Municipio{ IdMunicipio = 73, MunicipioNombre = "Nagua", IdProvincia =16},
                new Models.Municipio{ IdMunicipio = 74, MunicipioNombre = "Cabrera", IdProvincia =16},
                new Models.Municipio{ IdMunicipio = 75, MunicipioNombre = "El Factor", IdProvincia =16},
                new Models.Municipio{ IdMunicipio = 76, MunicipioNombre = "Río San Juan", IdProvincia =16},
                new Models.Municipio{ IdMunicipio = 77, MunicipioNombre = "Bonao", IdProvincia =17},
                new Models.Municipio{ IdMunicipio = 78, MunicipioNombre = "Maimón", IdProvincia =17},
                new Models.Municipio{ IdMunicipio = 79, MunicipioNombre = "Piedra Blanca", IdProvincia =17},
                new Models.Municipio{ IdMunicipio = 80, MunicipioNombre = "Montecristi", IdProvincia =18},
                new Models.Municipio{ IdMunicipio = 81, MunicipioNombre = "Castañuela", IdProvincia =18},
                new Models.Municipio{ IdMunicipio = 82, MunicipioNombre = "Guayubín", IdProvincia =18},
                new Models.Municipio{ IdMunicipio = 83, MunicipioNombre = "Las Matas de Santa Cruz", IdProvincia =18},
                new Models.Municipio{ IdMunicipio = 84, MunicipioNombre = "Pepillo Salcedo", IdProvincia =18},
                new Models.Municipio{ IdMunicipio = 85, MunicipioNombre = "Villa Vásquez", IdProvincia =18},
                new Models.Municipio{ IdMunicipio = 86, MunicipioNombre = "Monte Plata", IdProvincia =19},
                new Models.Municipio{ IdMunicipio = 87, MunicipioNombre = "Bayaguana", IdProvincia =19},
                new Models.Municipio{ IdMunicipio = 88, MunicipioNombre = "Peralvillo", IdProvincia =19},
                new Models.Municipio{ IdMunicipio = 89, MunicipioNombre = "Sabana Grande de Boyá", IdProvincia =19},
                new Models.Municipio{ IdMunicipio = 90, MunicipioNombre = "Yamasá", IdProvincia =19},
                new Models.Municipio{ IdMunicipio = 91, MunicipioNombre = "Pedernales", IdProvincia =20},
                new Models.Municipio{ IdMunicipio = 92, MunicipioNombre = "Oviedo", IdProvincia =20},
                new Models.Municipio{ IdMunicipio = 93, MunicipioNombre = "Baní", IdProvincia =21},
                new Models.Municipio{ IdMunicipio = 94, MunicipioNombre = "Nizao", IdProvincia =21},
                new Models.Municipio{ IdMunicipio = 95, MunicipioNombre = "Puerto Plata", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 96, MunicipioNombre = "Altamira", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 97, MunicipioNombre = "Guananico", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 98, MunicipioNombre = "Imbert", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 99, MunicipioNombre = "Los Hidalgos", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 100,MunicipioNombre = "Luperón", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 101,MunicipioNombre = "Sosúa", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 102,MunicipioNombre = "Villa Isabela", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 103,MunicipioNombre = "Villa Montellano", IdProvincia =22},
                new Models.Municipio{ IdMunicipio = 104,MunicipioNombre = "Samaná", IdProvincia =23},
                new Models.Municipio{ IdMunicipio = 105,MunicipioNombre = "Las Terrenas", IdProvincia =23},
                new Models.Municipio{ IdMunicipio = 106,MunicipioNombre = "Sánchez", IdProvincia =23},
                new Models.Municipio{ IdMunicipio = 107,MunicipioNombre = "San Cristóbal", IdProvincia =25},
                new Models.Municipio{ IdMunicipio = 108,MunicipioNombre = "Bajos de Haina", IdProvincia =25},
                new Models.Municipio{ IdMunicipio = 109,MunicipioNombre = "Cambita Garabito", IdProvincia =25},
                new Models.Municipio{ IdMunicipio = 110,MunicipioNombre = "Los Cacaos", IdProvincia =25},
                new Models.Municipio{ IdMunicipio = 111,MunicipioNombre = "Sabana Grande de Palenque", IdProvincia =25},
                new Models.Municipio{ IdMunicipio = 112,MunicipioNombre = "San Gregorio de Nigua", IdProvincia =25},
                new Models.Municipio{ IdMunicipio = 113,MunicipioNombre = "Villa Altagracia", IdProvincia =25},
                new Models.Municipio{ IdMunicipio = 114,MunicipioNombre = "Yaguate", IdProvincia =25},
                new Models.Municipio{ IdMunicipio = 115,MunicipioNombre = "San José de Ocoa", IdProvincia =26},
                new Models.Municipio{ IdMunicipio = 116,MunicipioNombre = "Rancho Arriba", IdProvincia =26},
                new Models.Municipio{ IdMunicipio = 117,MunicipioNombre = "Sabana Larga", IdProvincia =26},
                new Models.Municipio{ IdMunicipio = 118,MunicipioNombre = "San Juan de la Maguana", IdProvincia =27},
                new Models.Municipio{ IdMunicipio = 119,MunicipioNombre = "Bohechío", IdProvincia =27},
                new Models.Municipio{ IdMunicipio = 120,MunicipioNombre = "El Cercado", IdProvincia =27},
                new Models.Municipio{ IdMunicipio = 121,MunicipioNombre = "Juan de Herrera", IdProvincia =27},
                new Models.Municipio{ IdMunicipio = 122,MunicipioNombre = "Las Matas de Farfán", IdProvincia =27},
                new Models.Municipio{ IdMunicipio = 123,MunicipioNombre = "Vallejuelo", IdProvincia =27},
                new Models.Municipio{ IdMunicipio = 124,MunicipioNombre = "San Pedro de Macorís", IdProvincia =28},
                new Models.Municipio{ IdMunicipio = 125,MunicipioNombre = "Consuelo", IdProvincia =28},
                new Models.Municipio{ IdMunicipio = 126,MunicipioNombre = "Guayacanes", IdProvincia =28},
                new Models.Municipio{ IdMunicipio = 127,MunicipioNombre = "Quisqueya", IdProvincia =28},
                new Models.Municipio{ IdMunicipio = 128,MunicipioNombre = "Ramón Santana", IdProvincia =28},
                new Models.Municipio{ IdMunicipio = 129,MunicipioNombre = "San José de Los Llanos", IdProvincia =28},
                new Models.Municipio{ IdMunicipio = 130,MunicipioNombre = "Cotuí", IdProvincia =24},
                new Models.Municipio{ IdMunicipio = 131,MunicipioNombre = "Cevicos", IdProvincia =24},
                new Models.Municipio{ IdMunicipio = 132,MunicipioNombre = "Fantino", IdProvincia =24},
                new Models.Municipio{ IdMunicipio = 133,MunicipioNombre = "La Mata", IdProvincia =24},
                new Models.Municipio{ IdMunicipio = 134,MunicipioNombre = "Santiago", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 135,MunicipioNombre = "Bisonó", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 136,MunicipioNombre = "Jánico", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 137,MunicipioNombre = "Licey al Medio", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 138,MunicipioNombre = "Puñal", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 139,MunicipioNombre = "Sabana Iglesia", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 140,MunicipioNombre = "San José de las Matas", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 141,MunicipioNombre = "Tamboril", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 142,MunicipioNombre = "Villa González", IdProvincia =29},
                new Models.Municipio{ IdMunicipio = 143,MunicipioNombre = "San Ignacio de Sabaneta", IdProvincia =30},
                new Models.Municipio{ IdMunicipio = 144,MunicipioNombre = "Los Almácigos", IdProvincia =30},
                new Models.Municipio{ IdMunicipio = 145,MunicipioNombre = "Monción", IdProvincia =30},
                new Models.Municipio{ IdMunicipio = 146,MunicipioNombre = "Santo Domingo Este", IdProvincia =31},
                new Models.Municipio{ IdMunicipio = 147,MunicipioNombre = "Boca Chica", IdProvincia =31},
                new Models.Municipio{ IdMunicipio = 148,MunicipioNombre = "Los Alcarrizos", IdProvincia =31},
                new Models.Municipio{ IdMunicipio = 149,MunicipioNombre = "Pedro Brand", IdProvincia =31},
                new Models.Municipio{ IdMunicipio = 150,MunicipioNombre = "San Antonio de Guerra", IdProvincia =31},
                new Models.Municipio{ IdMunicipio = 151,MunicipioNombre = "Santo Domingo Norte", IdProvincia =31},
                new Models.Municipio{ IdMunicipio = 152,MunicipioNombre = "Santo Domingo Oeste", IdProvincia =31},
                new Models.Municipio{ IdMunicipio = 153,MunicipioNombre = "Mao", IdProvincia =32},
                new Models.Municipio{ IdMunicipio = 154,MunicipioNombre = "Esperanza", IdProvincia =32},
                new Models.Municipio{ IdMunicipio = 155,MunicipioNombre = "Laguna Salada", IdProvincia =32},
               });

        }
    }
}
