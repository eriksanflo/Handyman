using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Part
{
    public class DeletePartCreditCardCommand : IRequest<BaseResult>
    {
        public int IdTarjetaCliente { get; private set; }
        public DeletePartCreditCardCommand(int id) => IdTarjetaCliente = id;
    }
}
