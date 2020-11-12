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
    public class PutUnitQuotationHandler : IRequestHandler<UnitQuotationCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;

        public PutUnitQuotationHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<BaseResult> Handle(UnitQuotationCommand request, CancellationToken cancellationToken)
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


        private async Task Add(UnitQuotationCommand cmd)
        {
            _contex.UnidadCotizacion.Add(new UnidadCotizacion
            {
                IdUnidadCotizacion = cmd.Id,
                Abreviatura = cmd.Abbreviation,
                Nombre = cmd.Name,
                Activo = cmd.Active
            });
            await Task.CompletedTask;
        }

        private async Task Update(UnitQuotationCommand cmd)
        {
            var UnitQuotation = _contex.UnidadCotizacion.Single(x => x.IdUnidadCotizacion == cmd.Id);
            UnitQuotation.Abreviatura = cmd.Abbreviation;
            UnitQuotation.Nombre = cmd.Name;
            UnitQuotation.Activo = cmd.Active;
            await Task.CompletedTask;
        }
    }
}
