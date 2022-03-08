using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Direccion
    {
        public int IdDireccion { get; set; }
        public int IdCliente { get; set; }
        public int IdProvincia { get; set; }
        public int IdMunicipio { get; set; }
        public string Referencia { get; set; }
        public string Detalle { get; set; }
        public string Georeferencia { get; set; }

        public bool Eliminado { get; set; }
        public DateTime? FechaEliminado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
