using Aplicacion.Infraestructura.Persistencia;
using Aplicacion.Infraestructura.RegistroCivil.Interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using EcuatorianoDominio = Aplicacion.Dominio.Entidades.RegistroCivil.Ecuatoriano;

namespace Aplicacion.Caracteristicas.RegistroCivil
{
    public class AgregarCedula
    {
        public record DatosAgregarCedula(string Cedula, string CodigoDactilar);
        public record Comando(DatosAgregarCedula DatosCedula) : IRequest<RespuestaDTO>;
        public class Validador : AbstractValidator<Comando>
        {
            public Validador()
            {
                RuleFor(x => x.DatosCedula.Cedula)
                    .NotEmpty();

                RuleFor(x => x.DatosCedula.CodigoDactilar)
                    .NotEmpty();
            }
        }
        public class Handler : IRequestHandler<Comando, RespuestaDTO>
        {
            private readonly ContextoDB contextoDB;
            private readonly IMapper mapper;

            public Handler(ContextoDB contextoDB, IMapper mapper)
            {
                this.contextoDB = contextoDB;
                this.mapper = mapper;
            }

            public async Task<RespuestaDTO> Handle(Comando request, CancellationToken cancellationToken)
            {
                var ecuatoriano = mapper.Map<EcuatorianoDominio>(request.DatosCedula);
                contextoDB.Ecuatoriano.Add(ecuatoriano);
                await contextoDB.SaveChangesAsync(cancellationToken);
                return mapper.Map<RespuestaDTO>(ecuatoriano);
            }

            class MapRespuesta:Profile
            {
                public MapRespuesta()
                {
                    CreateMap<DatosAgregarCedula,EcuatorianoDominio>();
                    CreateMap<EcuatorianoDominio,RespuestaDTO>();
                }
            }
        }
        public record RespuestaDTO(int Id, string Cedula, string CodigoDactilar);
    }
}
