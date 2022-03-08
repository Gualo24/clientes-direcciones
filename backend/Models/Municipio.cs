using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Municipio
    {
        public int IdMunicipio { get; set; }
        public int IdProvincia { get; set; }
        public string MunicipioNombre { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual List<Direccion> Direcciones { get; set; }
    }
}
