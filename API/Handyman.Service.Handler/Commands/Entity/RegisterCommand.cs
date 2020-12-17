using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Entity
{
    public class RegisterCommand : IRequest<BaseResult>
    {
        public PersonInfo Person { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
