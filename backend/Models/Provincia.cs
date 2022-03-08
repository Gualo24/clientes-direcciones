using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string ProvinciaNombre { get; set; }
        public virtual List<Municipio> Municipios { get; set; }
        public virtual List<Direccion> Direcciones { get; set; }
    }
}
