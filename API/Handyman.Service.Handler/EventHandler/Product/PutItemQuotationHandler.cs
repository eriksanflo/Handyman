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
    class PutItemQuotationHandler : IRequestHandler<ItemQuotationCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;

        public PutItemQuotationHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        } 
        public async Task<BaseResult> Handle(ItemQuotationCommand request, CancellationToken cancellationToken)
        {
            var result = new BaseResult();
            try
            {
                var isNew = request.IdItemQuotation <= 0;
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
        private async Task Add(ItemQuotationCommand cmd)
        {
            _contex.ItemCotizacion.Add(new ItemCotizacion
            {
                IdItemCotizacion = cmd.IdItemQuotation,
                IdItem = cmd.IdItem,
                IdUnidadCotizacion = cmd.IdUnitQuotation,
                FechaInicial = cmd.InitialDate,
                FechaFinal = cmd.FinalDate
            });
            await Task.CompletedTask;
        }

        private async Task Update(ItemQuotationCommand cmd)
        {
            var ItemQuotation = _contex.ItemCotizacion.Single(x => x.IdItemCotizacion == cmd.IdItemQuotation);
            ItemQuotation.IdItem = cmd.IdItem;
            ItemQuotation.IdUnidadCotizacion = cmd.IdUnitQuotation;
            ItemQuotation.FechaInicial = cmd.InitialDate;
            ItemQuotation.FechaFinal = cmd.FinalDate;
            await Task.CompletedTask;
        }
    }
}
