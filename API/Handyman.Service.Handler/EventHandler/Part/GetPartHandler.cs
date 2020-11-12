using Handyman.Service.Handler.Commands.Part;
using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Part
{
    public class GetPartHandler : IRequestHandler<GetPartCommand, GetPartResult>
    {
        private readonly IApplicationDbContext _contex;
        private readonly ILogger<GetPartHandler> _logger;

        public GetPartHandler(IApplicationDbContext contex, ILogger<GetPartHandler> logger)
        {
            _contex = contex;
            _logger = logger;
        }
        public async Task<GetPartResult> Handle(GetPartCommand request, CancellationToken cancellationToken)
        {
            var response = new GetPartResult();
            try
            {
                var domain = _contex.ParteRole
                    .Include(x => x.IdParteNavigation)
                        .ThenInclude(x => x.Organizacion)
                    .Include(x => x.IdParteNavigation)
                        .ThenInclude(x => x.Persona)
                    .Single(x => x.IdParteRole == request.IdParteRole);
                
                var info = new PartResult();
                info.IdTipoParteRole = domain.IdTipoParteRole.Value;
                info.IdParteRole = domain.IdParteRole;

                var parte = domain.IdParteNavigation;
                if (parte.Persona != null)
                {
                    info.Person = new PersonInfo
                    {
                        IdParte = parte.Persona.IdParte,
                        Codigo = parte.Persona.Codigo,
                        NombrePrimario = parte.Persona.NombrePrimario,
                        NombreSecundario = parte.Persona.NombreSecundario,
                        Paterno = parte.Persona.Paterno,
                        Materno = parte.Persona.Materno,
                        TituloActual = parte.Persona.TituloActual,
                        Activo = parte.Persona.Activo,
                        Estatura = parte.Persona.Estatura,
                        FechaCreacion = parte.Persona.FechaCreacion,
                        FechaModificacion = parte.Persona.FechaModificacion,
                        FechaNacimiento = parte.Persona.FechaNacimiento,
                        Genero = parte.Persona.Genero,
                        LugarNacimiento = parte.Persona.LugarNacimiento,
                        Peso = parte.Persona.Peso
                    };
                }

                if (parte.Organizacion != null)
                {
                    info.Company = new OrganizacionInfo
                    {
                        IdParte = parte.Organizacion.IdParte,
                        Nombre = parte.Organizacion.Nombre,
                    };
                }

                response.PartInfo = info;
                response.SetSuccess();

            }
            catch (Exception ex)
            {
                _logger.LogError($"GetPartHandler: An error has orcurred: {ex.ToString()}");
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }
    }
}
