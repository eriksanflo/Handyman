using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Part
{
    public class DeletePartCommand : IRequest<BaseResult>
    {
        public int IdParteRole { get; set; }
        public DeletePartCommand(int id) => IdParteRole = id;
    }
}
