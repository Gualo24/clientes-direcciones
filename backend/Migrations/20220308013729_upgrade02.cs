using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class upgrade02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "IdProvincia", "ProvinciaNombre" },
                values: new object[,]
                {
                    { 1, "Azua" },
                    { 30, "Santiago Rodríguez" },
                    { 29, "Santiago" },
                    { 28, "San Pedro de Macorís" },
                    { 27, "San Juan" },
                    { 26, "San José de Ocoa" },
                    { 25, "San Cristóbal" },
                    { 24, "Sánchez Ramírez" },
                    { 23, "Samaná" },
                    { 22, "Puerto Plata" },
                    { 21, "Peravia" },
                    { 20, "Pedernales" },
                    { 19, "Monte Plata" },
                    { 18, "Monte Cristi" },
                    { 17, "Monseñor Nouel" },
                    { 16, "María Trinidad Sánchez" },
                    { 15, "La Vega" },
                    { 14, "La Romana" },
                    { 13, "La Altagracia" },
                    { 12, "Independencia" },
                    { 11, "Hermanas Mirabal" },
                    { 10, "Hato Mayor" },
                    { 9, "Espaillat" },
                    { 8, "El Seibo" },
                    { 7, "Elías Piña" },
                    { 6, "Duarte" },
                    { 5, "Distrito Nacional" },
                    { 4, "Dajabón" },
                    { 3, "Barahona" },
                    { 2, "Bahoruco" },
                    { 31, "Santo Domingo" },
                    { 32, "Valverde" }
                });

            migrationBuilder.InsertData(
                table: "Municipios",
                columns: new[] { "IdMunicipio", "IdProvincia", "MunicipioNombre" },
                values: new object[,]
                {
                    { 2, 1, "Azua de Compostela" },
                    { 100, 22, "Luperón" },
                    { 101, 22, "Sosúa" },
                    { 102, 22, "Villa Isabela" },
                    { 103, 22, "Villa Montellano" },
                    { 104, 23, "Samaná" },
                    { 105, 23, "Las Terrenas" },
                    { 106, 23, "Sánchez" },
                    { 130, 24, "Cotuí" },
                    { 131, 24, "Cevicos" },
                    { 132, 24, "Fantino" },
                    { 133, 24, "La Mata" },
                    { 107, 25, "San Cristóbal" },
                    { 108, 25, "Bajos de Haina" },
                    { 109, 25, "Cambita Garabito" },
                    { 110, 25, "Los Cacaos" },
                    { 99, 22, "Los Hidalgos" },
                    { 98, 22, "Imbert" },
                    { 97, 22, "Guananico" },
                    { 96, 22, "Altamira" },
                    { 80, 18, "Montecristi" },
                    { 81, 18, "Castañuela" },
                    { 82, 18, "Guayubín" },
                    { 83, 18, "Las Matas de Santa Cruz" },
                    { 84, 18, "Pepillo Salcedo" },
                    { 85, 18, "Villa Vásquez" },
                    { 86, 19, "Monte Plata" },
                    { 111, 25, "Sabana Grande de Palenque" },
                    { 87, 19, "Bayaguana" },
                    { 89, 19, "Sabana Grande de Boyá" },
                    { 90, 19, "Yamasá" },
                    { 91, 20, "Pedernales" },
                    { 92, 20, "Oviedo" },
                    { 93, 21, "Baní" },
                    { 94, 21, "Nizao" },
                    { 95, 22, "Puerto Plata" },
                    { 88, 19, "Peralvillo" },
                    { 79, 17, "Piedra Blanca" },
                    { 112, 25, "San Gregorio de Nigua" },
                    { 114, 25, "Yaguate" },
                    { 139, 29, "Sabana Iglesia" },
                    { 140, 29, "San José de las Matas" }
                });

            migrationBuilder.InsertData(
                table: "Municipios",
                columns: new[] { "IdMunicipio", "IdProvincia", "MunicipioNombre" },
                values: new object[,]
                {
                    { 141, 29, "Tamboril" },
                    { 142, 29, "Villa González" },
                    { 143, 30, "San Ignacio de Sabaneta" },
                    { 144, 30, "Los Almácigos" },
                    { 145, 30, "Monción" },
                    { 146, 31, "Santo Domingo Este" },
                    { 147, 31, "Boca Chica" },
                    { 148, 31, "Los Alcarrizos" },
                    { 149, 31, "Pedro Brand" },
                    { 150, 31, "San Antonio de Guerra" },
                    { 151, 31, "Santo Domingo Norte" },
                    { 152, 31, "Santo Domingo Oeste" },
                    { 153, 32, "Mao" },
                    { 138, 29, "Puñal" },
                    { 137, 29, "Licey al Medio" },
                    { 136, 29, "Jánico" },
                    { 135, 29, "Bisonó" },
                    { 115, 26, "San José de Ocoa" },
                    { 116, 26, "Rancho Arriba" },
                    { 117, 26, "Sabana Larga" },
                    { 118, 27, "San Juan de la Maguana" },
                    { 119, 27, "Bohechío" },
                    { 120, 27, "El Cercado" },
                    { 121, 27, "Juan de Herrera" },
                    { 113, 25, "Villa Altagracia" },
                    { 122, 27, "Las Matas de Farfán" },
                    { 124, 28, "San Pedro de Macorís" },
                    { 125, 28, "Consuelo" },
                    { 126, 28, "Guayacanes" },
                    { 127, 28, "Quisqueya" },
                    { 128, 28, "Ramón Santana" },
                    { 129, 28, "San José de Los Llanos" },
                    { 134, 29, "Santiago" },
                    { 123, 27, "Vallejuelo" },
                    { 154, 32, "Esperanza" },
                    { 78, 17, "Maimón" },
                    { 76, 16, "Río San Juan" },
                    { 23, 3, "La Ciénaga" },
                    { 24, 3, "Las Salinas" },
                    { 25, 3, "Paraíso" },
                    { 26, 3, "Polo" },
                    { 27, 3, "Vicente Noble" }
                });

            migrationBuilder.InsertData(
                table: "Municipios",
                columns: new[] { "IdMunicipio", "IdProvincia", "MunicipioNombre" },
                values: new object[,]
                {
                    { 28, 4, "Dajabón" },
                    { 29, 4, "El Pino" },
                    { 30, 4, "Loma de Cabrera" },
                    { 31, 4, "Partido" },
                    { 32, 4, "Restauración" },
                    { 1, 5, "Distrito Nacional" },
                    { 33, 6, "San Francisco de Macorís" },
                    { 34, 6, "Arenoso" },
                    { 35, 6, "Castillo" },
                    { 36, 6, "Eugenio María de Hostos" },
                    { 22, 3, "Jaquimeyes" },
                    { 21, 3, "Fundación" },
                    { 20, 3, "Enriquillo" },
                    { 19, 3, "El Peñón" },
                    { 3, 1, "Estebanía" },
                    { 4, 1, "Guayabal" },
                    { 5, 1, "Las Charcas" },
                    { 6, 1, "Las Yayas de Viajama" },
                    { 7, 1, "Padre Las Casas" },
                    { 8, 1, "Peralta" },
                    { 9, 1, "Pueblo Viejo" },
                    { 37, 6, "Las Guáranas" },
                    { 10, 1, "Sabana Yegua" },
                    { 12, 2, "Neiba" },
                    { 13, 2, "Galván" },
                    { 14, 2, "Los Ríos" },
                    { 15, 2, "Tamayo" },
                    { 16, 2, "Villa Jaragua" },
                    { 17, 3, "Barahona" },
                    { 18, 3, "Cabral" },
                    { 11, 1, "Tábara Arriba" },
                    { 77, 17, "Bonao" },
                    { 38, 6, "Pimentel" },
                    { 42, 7, "Comendador" },
                    { 61, 12, "La Descubierta" },
                    { 62, 12, "Mella" },
                    { 63, 12, "Postrer Río" },
                    { 64, 13, "Higüey" },
                    { 65, 13, "San Rafael del Yuma" },
                    { 66, 14, "La Romana" },
                    { 67, 14, "Guaymate" },
                    { 68, 14, "Villa Hermosa" }
                });

            migrationBuilder.InsertData(
                table: "Municipios",
                columns: new[] { "IdMunicipio", "IdProvincia", "MunicipioNombre" },
                values: new object[,]
                {
                    { 69, 15, "La Concepción de La Vega" },
                    { 70, 15, "Constanza" },
                    { 71, 15, "Jarabacoa" },
                    { 72, 15, "Jima Abajo" },
                    { 73, 16, "Nagua" },
                    { 74, 16, "Cabrera" },
                    { 75, 16, "El Factor" },
                    { 60, 12, "Duvergé" },
                    { 59, 12, "Cristóbal" },
                    { 58, 12, "Jimaní" },
                    { 57, 11, "Villa Tapia" },
                    { 43, 7, "Bánica" },
                    { 44, 7, "El Llano" },
                    { 45, 7, "Hondo Valle" },
                    { 46, 7, "Juan Santiago" },
                    { 47, 7, "Pedro Santana" },
                    { 40, 8, "El Seibo" },
                    { 41, 8, "Miches" },
                    { 39, 6, "Villa Riva" },
                    { 48, 9, "Moca" },
                    { 50, 9, "Gaspar Hernández" },
                    { 51, 9, "Jamao al Norte" },
                    { 52, 10, "Hato Mayor del Rey" },
                    { 53, 10, "El Valle" },
                    { 54, 10, "Sabana de la Mar" },
                    { 55, 11, "Salcedo" },
                    { 56, 11, "Tenares" },
                    { 49, 9, "Cayetano Germosén" },
                    { 155, 32, "Laguna Salada" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Municipios",
                keyColumn: "IdMunicipio",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Provincias",
                keyColumn: "IdProvincia",
                keyValue: 32);
        }
    }
}
