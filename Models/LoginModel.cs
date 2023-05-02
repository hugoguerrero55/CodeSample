using System;
using System.Collections.Generic;
using System.Text;

namespace Chronos.Models
{
    public class LoginModel
    {
        public string nombre { get; set; } //Es el nombre del cliente o compañía
        public int? folioCliente { get; set; }
        public int? _SecondFactor { get; set; }
        public string logotipo { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public int Id_Miembro { get; set; }
        public string NombreMiembro { get; set; }
    }
}
