using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Contact
{
    public class CreateContactMethodPartCommand : ContactMethodPartInfo, IRequest<BaseResult>
    {
        public int IdTipoPropositoContacto { get; set; }
    }
}
