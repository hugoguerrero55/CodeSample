using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chronos.Models
{
    public class HistoriaActividad
    {
        public int Id_HistMemAct { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Sucursal { get; set; }
        public int Id_Grupo { get; set; }
        public int Id_TipoActividad { get; set; }
        public int Id_Actividad { get; set; }
        public int Id_Miembro { get; set; }
        public int CodQR { get; set; }
        public DateTime FechaRegistroAct { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public string FotoPath { get; set; }

    }
}
