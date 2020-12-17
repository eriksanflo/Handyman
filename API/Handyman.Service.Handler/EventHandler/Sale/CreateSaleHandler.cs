using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Sale;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Sale
{
    public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly IApplicationDbContext _contex;
        public CreateSaleHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<CreateSaleResult> Handle(CreateSaleCommand request, CancellationToken cancellationToken)
        {
            var response = new CreateSaleResult();
            try
            {
                var domain = Build(request);
                _contex.Venta.Add(domain);
                await _contex.SaveChangesAsync();
                domain.Folio = GenerateFolio(domain.IdVenta);
                await _contex.SaveChangesAsync();
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }

        private Venta Build(CreateSaleCommand request)
        {
            var domain = new Venta
            {
                IdTipoVenta = request.SaleType,
                Fecha = DateTime.Now,
                FechaRegistro = DateTime.Now,
            };

            var index = 1;
            foreach (var item in request.Details)
            {
                var detail = new VentaDetalle
                {
                    IdItem = item.ProductId,
                    IdTipoItem = item.ProductTypeId,
                    IdItemPrecio = item.ProductPriceId,
                    Cantidad = item.Quantity,
                    Precio = item.Price,
                    Importe = item.Amount,
                    FechaCompromiso = item.SupplyDate,
                    Secuencia = (short)index++,
                    Observaciones = item.Notes,
                };
                index++;
                domain.VentaDetalle.Add(detail);
            }

            if (request.Customer != null)
            {
                domain.VentaRole.Add(new VentaRole 
                { 
                    IdTipoParteRole = request.Customer.CustomerPartTypeId,
                    IdParteRole = request.Customer.CustomerId,
                    FechaInicial = DateTime.Now,
                });
            }

            return domain;
        }
        private string GenerateFolio(int id)
        {
            var length = $"00000000{id}";
            return length.Substring(length.Length - 8);
        }
        private void ApplyAllStatus(ref Venta domain)
        {

        }
        private void ApplyAllStatus(ref VentaDetalle domain)
        {

        }
    }
}
