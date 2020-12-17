using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Product
{
    public class DeleteItemCommand : IRequest<BaseResult>
    {
        public int IdItem { get; set; }
        public DeleteItemCommand(int idItem) => IdItem = idItem;
    }
}
