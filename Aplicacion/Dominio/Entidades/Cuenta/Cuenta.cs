using Aplicacion.Dominio.Comunes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dominio.Entidades.Cuenta
{
    public class Cuenta:EntidadBase
    {
        public string Numero { get; set; } = string.Empty;
        public double Saldo { get; set; }
        public int IdUsuario { get; set; }
    }
}
