using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DTOs
{
    public class Cliente
    {
        public class ClienteCreate
        {
            [Required(ErrorMessage = "Favor coloque el nombre del cliente")]
            public string Nombres { get; set; }
            [Required(ErrorMessage = "Favor coloque el apellido del cliente")]
            public string Apellidos { get; set; }
            [Required(ErrorMessage = "Favor coloque el correo electronico")]
            [DataType(DataType.EmailAddress)]
            [EmailAddress(ErrorMessage = "No es un correo valido")]
            public string CorreoElectronico { get; set; }
            [Required(ErrorMessage = "Favor coloque el numero de telefono")]
            [DataType(DataType.PhoneNumber)]
            [Phone(ErrorMessage = "No es un telefono valido")]
            public string Telefono { get; set; }
        }

        public class ClienteUpdate
        {
            [Required(ErrorMessage = "Coloque el id del cliente")]
            public int IdCliente { get; set; }
            [Required(ErrorMessage = "Favor coloque el nombre del cliente")]
            public string Nombres { get; set; }
            [Required(ErrorMessage = "Favor coloque el apellido del cliente")]
            public string Apellidos { get; set; }
            [Required(ErrorMessage = "Favor coloque el correo electronico")]
            [DataType(DataType.EmailAddress)]
            [EmailAddress(ErrorMessage = "No es un correo valido")]
            public string CorreoElectronico { get; set; }
            [Required(ErrorMessage = "Favor coloque el numero de telefono")]
            [DataType(DataType.PhoneNumber)]
            [Phone(ErrorMessage = "No es un telefono valido")]
            public string Telefono { get; set; }
        }
    }
}
