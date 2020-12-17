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
    }
}
