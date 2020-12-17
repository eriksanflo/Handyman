using Handyman.Service.Handler.Commands.Reporting;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Reporting
{
    public class GetSaleDescriptionHandler : IRequestHandler<GetSaleDescriptionCommand, SaleDescriptionResult>
    {
        private readonly IApplicationDbContext _contex;
        public GetSaleDescriptionHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<SaleDescriptionResult> Handle(GetSaleDescriptionCommand request, CancellationToken cancellationToken)
        {
            var response = new SaleDescriptionResult();
            try
            {
                response.Resume = new SaleDescriptionInfo();
                var sale = _contex.Venta
                    .Include(x => x.VentaDetalle)
                    .Include(x => x.VentaRole)
                    .Include(x => x.VentaDetalle)
                        .ThenInclude(x => x.VentaDetalleExtra)
                    .Include(x => x.VentaDetalle)
                        .ThenInclude(x => x.VentaDetalleImagen)
                    .Single(x => x.IdVenta == request.Id);
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return await Task.FromResult(response);
        }
    }
}
