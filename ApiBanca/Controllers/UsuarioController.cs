using ApiBanca.Controllers.Interfaces;
using Aplicacion.Caracteristicas.RegistroCivil;
using Aplicacion.Caracteristicas.Usuario;
using Aplicacion.Helper.Comunes;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiBanca.Controllers
{
    public class UsuarioController : ApiBaseController
    {
        [HttpPost("crear-cuenta")]
        public async Task<ActionResult> CrearUsuario(CrearUsuario.CrearUsuarioDTO request)
        {
            try
            {
                var resultado = await Mediator.Send(new CrearUsuario.Comando(request));
                return Ok(resultado);
            }
            catch (ExcepcionValidacion error)
            {
                return BadRequest(new { Mensaje = error.Message, error.Errors });
            }
            catch (Exception error)
            {
                return BadRequest(new { Mensaje = error.Message });
            }
        }

        [HttpPut("verificar-cuenta")]
        public async Task<ActionResult> VerificarCuenta(VerificarCuenta.VerificarCuentaDTO request)
        {
            try
            {
                var resultado = await Mediator.Send(new VerificarCuenta.Comando(request));
                return Ok(resultado);
            }
            catch (ExcepcionValidacion error)
            {
                return BadRequest(new { Mensaje = error.Message, error.Errors });
            }
            catch (Exception error)
            {
                return BadRequest(new { Mensaje = error.Message });
            }
        }
    }
}
