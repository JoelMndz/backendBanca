using Aplicacion.Infraestructura.RegistroCivil.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Infraestructura.RegistroCivil.Implementaciones
{
    public class RegistroCivilAPI : IRegistroCivil
    {
        public async Task<bool> ValidarDatosCedula(string cedula, string codigoDactilar)
        {
            //LOGICA

            return true;
        }

        public async Task<bool> ValidarRostro(string rostroBase64)
        {
            //LOGICA

            return true;
        }
    }
}
