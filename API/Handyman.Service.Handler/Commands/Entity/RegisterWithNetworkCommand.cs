using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Entity
{
    public class RegisterWithNetworkCommand : RegisterCommand, IRequest<BaseResult>
    {
        public string Provider { get; set; }
    }
}
