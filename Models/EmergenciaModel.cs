using System;
using System.Collections.Generic;
using System.Text;

namespace Chronos.Models
{
    public class EmergenciaModel
    {
        public int Id_Emergencia { get; set; }
        public int Id_Miembro { get; set; }
        public string TextoEmergencia { get; set; }
        //public string  FechaEmergencia { get; set; }
        public string RutaVideo { get; set; }
        public string Emergencia { get; internal set; }
    }
}
