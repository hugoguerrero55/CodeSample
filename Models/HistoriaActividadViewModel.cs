using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chronos.Models
{
    public class HistoriaActividadViewModel
    {
        public int Id_Miembro { get; set; }
        public IFormFile FotoPath { get; set; }
    }
}
