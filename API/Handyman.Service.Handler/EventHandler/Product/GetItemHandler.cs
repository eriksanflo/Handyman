using Handyman.Service.Handler.Commands.Product;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Product
{
    public class GetItemHandler : IRequestHandler<GetItemCommand, GetItemResult>
    {
        private readonly IApplicationDbContext _contex;
        public GetItemHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<GetItemResult> Handle(GetItemCommand request, CancellationToken cancellationToken)
        {
            var result = new GetItemResult();
            try
            {
                var item = _contex.Item
                    .Include(x => x.ItemCotizacion)
                    .Include(x => x.ItemPrecio)
                    .Single(x => x.IdItem == request.IdItem);

                var info = new ItemResult
                {
                    Active = item.Activo ?? false,
                    Code = item.Codigo,
                    Description = item.Nombre,
                    IdCategory = item.IdTipoItem ?? int.MinValue,
                    IdProduct = item.IdItem,
                    IdUnitSale = item.ItemCotizacion?.FirstOrDefault().IdItemCotizacion ?? int.MaxValue,
                    ImageUri = item.ItemServicio?.ImagenUrl,
                    Prices = item.ItemPrecio.Select(x => new PriceConfiguration 
                    { 
                        Active = x.Activo,
                        FromDate = x.FechaInicial.Value,
                        FromQuantity = x.Desde,
                        Id = x.IdItemPrecio,
                        IdItem = x.IdItem,
                        IdItemCotizacion = x.IdItemCotizacion,
                        Price = x.Precio ?? decimal.Zero,
                        ToDate = x.FechaFinal,
                        ToQuantity = x.Hasta,
                    }).ToList(),
                };
                result.ItemInfo = info;
                result.SetSuccess();
            }
            catch (Exception ex)
            {
                result.BuildBadRequest(ex.Message);
            }
            return result;
        }
    }
}
