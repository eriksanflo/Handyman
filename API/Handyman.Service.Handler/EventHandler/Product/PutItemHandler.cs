using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Product;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Product
{
    public class PutItemHandler : IRequestHandler<ItemCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;

        public PutItemHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<BaseResult> Handle(ItemCommand request, CancellationToken cancellationToken)
        {
            var result = new BaseResult();
            try
            {
                var isNew = request.IdProduct <= 0;
                var domain = isNew ? new Item() : GetEntity(request.IdProduct);
                domain.IdTipoItem = request.IdCategory;
                domain.Codigo = request.Code;
                domain.Nombre = request.Description;
                domain.Activo = request.Active;
                await AttachPrices(domain, request);

                await _contex.SaveChangesAsync();
                result.SetSuccess();
            }
            catch (Exception ex)
            {
                result.BuildBadRequest(ex.Message);
            }
            return result;
        }
        private Item GetEntity(int id)
        {
            return _contex.Item
                .Include(x => x.ItemServicio)
                .Include(x => x.ItemCotizacion)
                .Include(x => x.ItemPrecio)
                .Single(x => x.IdItem == id);
        }
        private async Task AttachPrices(Item domain, ItemCommand request)
        {
            foreach (var item in request.Prices)
            {
                var isNew = domain.ItemPrecio.Any(x => x.IdItemPrecio == item.Id);
                var model = isNew ? domain.ItemPrecio.FirstOrDefault(x => x.IdItemPrecio == item.Id) : new ItemPrecio();
                model.IdItem = item.IdItem;
                model.IdItemCotizacion = item.IdItemCotizacion;
                model.Desde = item.FromQuantity;
                model.Hasta = item.ToQuantity;
                model.FechaInicial = item.FromDate.DateTime;
                model.FechaFinal = item.ToDate.GetValueOrDefault().DateTime;
                model.Precio = item.Price;
                model.Activo = item.Active;
                if (isNew)
                    domain.ItemPrecio.Add(model);
            }
            await Task.CompletedTask;
        }
    }
}
