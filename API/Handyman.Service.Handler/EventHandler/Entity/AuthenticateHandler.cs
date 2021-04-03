using Handyman.Common;
using Handyman.Service.Handler.Commands.Entity;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Entity
{
    public class AuthenticateHandler : IRequestHandler<AuthenticateCommand, AuthenticateResult>
    {
        private readonly IApplicationDbContext _contex;
        public AuthenticateHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<AuthenticateResult> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            var response = new AuthenticateResult();
            try
            {
                var src = _contex.Accesos
                    .Include(x => x.IdParteNavigation)
                        .ThenInclude(x => x.Persona)
                    .Include(x => x.IdParteNavigation)
                        .ThenInclude(x => x.MedioContactoParte)
                    .Where(x => x.Usuario == request.User && x.Password == request.Pass);
                if (!src.Any(x => x.Usuario == request.User && x.Password == request.Pass))
                    throw new ArgumentException("Usuario o Contraseña incorrectos");

                var match = src.FirstOrDefault();
                response.TokenInfo = new EntityToken() 
                { 
                    AccessToken = match.IdParte.ToString(),
                    IdParte = match.IdParte.ToString(),
                    Usuario = match.Usuario,
                    Codigo = match.IdParteNavigation.Persona.Codigo,
                    Nombre = match.IdParteNavigation.Persona.NombrePrimario,
                    Paterno = match.IdParteNavigation.Persona.Paterno,
                    Materno = match.IdParteNavigation.Persona.Materno,
                    Telefono = match.IdParteNavigation.MedioContactoParte.FirstOrDefault(x => x.IdPropositoContacto == (int)ePropositoContacto.Movil).Contacto,
                };

                response.SetSuccess();
            }
            catch (ArgumentException arr)
            {
                response.BuildBadRequest(arr.Message);
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return await Task.FromResult(response);
        }
    }
}
