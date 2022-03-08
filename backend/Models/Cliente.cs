using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }

        public bool Eliminado { get; set; }
        public DateTime? FechaEliminado { get; set; }

        public virtual List<Direccion> Direcciones { get; set; }
    }
}
