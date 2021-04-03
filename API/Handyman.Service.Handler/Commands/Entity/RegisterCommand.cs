using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Entity
{
    public class RegisterCommand : IRequest<BaseResult>
    {
        public PersonInfo Person { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string MobilePhone { get; set; }
        public int RoleType { get; set; }
        public List<PartDocumentInfo> Documents { get; set; }
    }
}
