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
                if (isNew)
                    await Create(request);
                else
                    await Update(request);

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
        private async Task Create(ItemCommand request)
        {
            var _item = new Item
            {
                IdTipoItem = request.IdCategory,
                Codigo = request.Code,
                Nombre = request.Description,
            };
            _contex.Item.Add(_item);
            await Task.CompletedTask;
        }
        private async Task Update(ItemCommand request)
        {
            var _item = GetEntity(request.IdProduct);
            _item.Codigo = request.Code;
            if (_item.ItemServicio == null && !string.IsNullOrEmpty(request.ImageUri))
            {
                _item.ItemServicio = new ItemServicio
                {
                    ImagenUrl = request.ImageUri
                };
            }
            else if (_item.ItemServicio != null)
            {
                _item.ItemServicio.ImagenUrl = request.ImageUri;
            }
            await Task.CompletedTask;
        }
    }
}
