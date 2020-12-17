using Handyman.Common;
using Handyman.Service.Handler.Commands.Sale;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Sale
{
    public class TransformToSalehandler : IRequestHandler<TransformToSaleCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;
        public TransformToSalehandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<BaseResult> Handle(TransformToSaleCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResult();
            try
            {
                var domain = _contex.Venta.Single(x => x.IdVenta == request.SaleId);
                domain.IdTipoVenta = (int)eTipoVenta.Cotizacion;
                await _contex.SaveChangesAsync();
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }
    }
}
