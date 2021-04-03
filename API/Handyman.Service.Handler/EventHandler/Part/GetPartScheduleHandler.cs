using Handyman.Service.Handler.Commands.Part;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Part
{
    public class GetPartScheduleHandler : IRequestHandler<GetPartScheduleCommand, PartScheduleResult>
    {
        private readonly IProcedureDbContext _contex;
        public GetPartScheduleHandler(IProcedureDbContext contex)
        {
            _contex = contex;
        }
        public async Task<PartScheduleResult> Handle(GetPartScheduleCommand request, CancellationToken cancellationToken)
        {
            var result = new PartScheduleResult();
            try
            {
                var data = await _contex.GetPartScheduleAsync(request.IdParte);
                result.ListItems = data.Select(x => new PartScheduleItem
                {
                    IdParte = x.IdParte,
                    Cantidad = x.Cantidad,
                    FechaCompromiso = x.FechaCompromiso.DateTime,
                    Folio = x.Folio,
                    IdItem = x.IdItem,
                    IdItemPrecio = x.IdItemPrecio,
                    IdParteRole = x.IdParteRole,
                    IdTipoItem = x.IdTipoItem,
                    IdTipoVenta = x.IdTipoVenta,
                    IdVenta = x.IdVenta,
                    Importe = x.Importe,
                    Item = x.Item,
                    Observaciones = x.Observaciones,
                    Precio = x.Precio,
                    TipoItem = x.TipoItem
                }).ToList();
            }
            catch (Exception ex)
            { }
            return result;
        }
    }
}
