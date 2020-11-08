using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Contact
{
    public class DeleteContactMethodPartCommand : IRequest<BaseResult>
    {
        public int IdMedioContactoParte { get; set; }
        public DeleteContactMethodPartCommand(int id) => IdMedioContactoParte = id;
    }
}
