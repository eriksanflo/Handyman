using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Product;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Product
{
    public class PutCategoryHandler : IRequestHandler<CategoryCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;

        public PutCategoryHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<BaseResult> Handle(CategoryCommand request, CancellationToken cancellationToken)
        {
            var result = new BaseResult();
            try
            {
                var isNew = request.Id <= 0;
                if (isNew)
                    await Add(request);
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

        private async Task Add(CategoryCommand cmd)
        {
            _contex.TipoItem.Add(new TipoItem
            {
                Nombre = cmd.Name,
                Categoria = cmd.IsCategory,
                ImagenUrl = cmd.ImagePath,
                Activo = true,
            });
            await Task.CompletedTask;
        }

        private async Task Update(CategoryCommand cmd)
        {
            var category = _contex.TipoItem.Single(x => x.IdTipoItem == cmd.Id);
            category.Activo = cmd.Active;
            category.Nombre = cmd.Name;
            await Task.CompletedTask;
        }
        ///Prueba nueva rama GitHub
    }
}
