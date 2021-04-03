using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Entity
{
    public class AuthenticateCommand : IRequest<AuthenticateResult> 
    {
        public string User { get; set; }
        public string Pass { get; set; }
    }

    public class AuthenticateResult : BaseResult
    {
        public EntityToken TokenInfo { get; set; }
    }

    public class EntityToken
    {
        public string AccessToken { get; set; }
        public string IdParte { get; set; }
        public string Usuario { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Telefono { get; set; }
    }
}
