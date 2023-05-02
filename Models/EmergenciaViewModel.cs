using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chronos.Models
{
    public class EmergenciaViewModel
    {
        public int Id_Miembro { get; set; }
        public string TextoEmergencia { get; set; }
        public IFormFile RutaVideo { get; set; }
    }
}
