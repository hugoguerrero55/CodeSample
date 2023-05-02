using System;
using System.Collections.Generic;
using System.Text;

namespace Chronos.Models
{
    public class ActividadModel
    {
        public string NombreCliente { get; set; }
        public int FolioCliente { get; set; }
        public string Logotipo { get; set; }
        public int Id_Miembro { get; set; }
        public string NombreMiembro { get; set; }
        public int TipoActividad { get; set; }
        public string Dispositivo { get; set; }
    }
}