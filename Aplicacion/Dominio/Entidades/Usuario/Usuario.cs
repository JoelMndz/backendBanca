using Aplicacion.Dominio.Comunes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dominio.Entidades.Usuario
{
    public class Usuario : EntidadBase
    {
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public string CodigoDactilar { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string FotoRostroURL { get; set; } = string.Empty;
        public string SituacionLaboral { get; set; } = string.Empty;
        public string? Empresa { get; set; }
        public string PaisPagoImpuestos { get; set; } = string.Empty;
        public bool AceptoTerminosYConcidiones { get; set; } = false;
    }
}
