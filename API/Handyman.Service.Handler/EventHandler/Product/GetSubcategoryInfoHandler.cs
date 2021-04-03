using Handyman.Service.Handler.Commands.Product;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Product
{
    public class GetSubcategoryInfoHandler : IRequestHandler<GetSubcategoryInfoCommand, SubcategoryInfoResult>
    {
        private readonly IProcedureDbContext _contex;
        public GetSubcategoryInfoHandler(IProcedureDbContext contex)
        {
            _contex = contex;
        }
        public async Task<SubcategoryInfoResult> Handle(GetSubcategoryInfoCommand request, CancellationToken cancellationToken)
        {
            var response = new SubcategoryInfoResult();
            try
            {
                var result = await _contex.GetSubcategoryInfoAsync(request.IdSubcategory, request.LocationDate);
                response.SubcategoryInfo = result.Select(x => new SubcategoryInfo {
                    IdTipoItem = x.IdTipoItem,
                    IdItem = x.IdItem,
                    IdItemCotizacion = x.IdItemCotizacion,
                    IdUnidadCotizacion = x.IdUnidadCotizacion,
                    IdItemPrecio = x.IdItemPrecio,
                    Nombre = x.Nombre,
                    Desde = x.Desde,
                    Hasta = x.Hasta,
                    Precio = x.Precio,
                }).ToList();
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
