using Aplicacion.Infraestructura.Persistencia;
using Aplicacion.Infraestructura.RegistroCivil.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Infraestructura.RegistroCivil.Implementaciones
{
    public class RegistroCivilFake : IRegistroCivil
    {
        public RegistroCivilFake(ContextoDB contexto)
        {
            this.contexto = contexto;
        }

        public ContextoDB contexto { get; }


        public Task<bool> ValidarRostro(string rostroBase64)
        {
            throw new NotImplementedException();
        }
    }
}
