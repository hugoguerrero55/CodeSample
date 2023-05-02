using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chronos.Models
{
    public class Emergencia
    {
        public int Id_Emergencia { get; set; }
        public int Id_Miembro { get; set; }
        public string TextoEmergencia { get; set; }
        public DateTime FechaEmergencia { get; set; }
        public string RutaVideo { get; set; }
    }
}
