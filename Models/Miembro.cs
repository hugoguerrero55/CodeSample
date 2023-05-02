using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chronos.Models
{
    public class Miembro
    {
        public int Id_Miembro { get; set; }
        public int Id_Grupo { get; set; }
        public int Id_Puesto { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string DireccionLinea1 { get; set; }
        public string DireccionLinea2 { get; set; }
        public string CodigoPostal { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public int Id_CiudadMunicipio { get; set; }
        public string Telefono { get; set; }
        public int? DoubleFactorCode { get; set; }
        public string PerfilImage { get; set; }
        public string Dispositivo { get; set; }
    }
}