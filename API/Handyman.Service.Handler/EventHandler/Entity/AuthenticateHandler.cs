using Handyman.Service.Handler.Commands.Entity;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
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
                if (!_contex.Accesos.Any(x => x.Usuario == request.User && x.Password == request.Pass))
                    throw new ArgumentException("Usuario o Contraseña incorrectos");

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
