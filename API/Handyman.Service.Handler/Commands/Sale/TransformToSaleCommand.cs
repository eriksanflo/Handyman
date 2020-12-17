using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Sale
{
    public class TransformToSaleCommand : IRequest<BaseResult>
    {
        public int SaleId { get; set; }
        public TransformToSaleCommand(int id) => SaleId = id;
    }
}
