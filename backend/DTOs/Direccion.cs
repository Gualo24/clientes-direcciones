using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DTOs
{
    public class Direccion
    {
        public class DireccionCreate
        {
            public int IdCliente { get; set; }
            public int IdProvincia { get; set; }
            public int IdMunicipio { get; set; }
            public string Referencia { get; set; }
            public string Detalle { get; set; }
        }

        public class DireccionUpdate
        {
            public int IdDireccion { get; set; }
            public int IdCliente { get; set; }
            public int IdProvincia { get; set; }
            public int IdMunicipio { get; set; }
            public string Referencia { get; set; }
            public string Detalle { get; set; }
            public string Georeferencia { get; set; }
        }
    }
}
