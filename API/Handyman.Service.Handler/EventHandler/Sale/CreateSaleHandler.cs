using Handyman.Common;
using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Sale;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var domain = await Build(request);
                _contex.Venta.Add(domain);
                await _contex.SaveChangesAsync();
                domain.Folio = GenerateFolio(domain.IdVenta);
                await _contex.SaveChangesAsync();

                response.SaleAffectedInfo = new SaleAffected
                {
                    SaleId = domain.IdVenta,
                    Folio = domain.Folio,
                };
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }

        private async Task<Venta> Build(CreateSaleCommand request)
        {
            var domain = new Venta
            {
                IdTipoVenta = request.SaleType,
                Fecha = DateTime.Now,
                FechaRegistro = DateTime.Now,
                IdOrden = request.IdOrder,
                IdTarjetaCliente = request.IdCustomerCard,
            };

            var index = 1;
            foreach (var item in request.Details)
            {
                var detail = new VentaDetalle
                {
                    IdItem = item.ProductId,
                    IdTipoItem = item.ProductTypeId,
                    IdItemPrecio = item.ProductPriceId <= 0 ? (int?)null : item.ProductPriceId,
                    Cantidad = item.Quantity,
                    Precio = item.Price,
                    Importe = decimal.Multiply(item.Quantity, item.Price),
                    FechaCompromiso = item.SupplyDate,
                    Secuencia = (short)index++,
                    Observaciones = item.Notes,
                };
                domain.VentaDetalle.Add(detail);
            }

            if (request.Images != null)
            {
                foreach (var item in request.Images)
                {
                    domain.VentaImagen.Add(new VentaImagen
                    {
                        Nombre = item.Name,
                        Extension = item.Extension,
                        Imagen = item.Source,
                    });
                }
            }

            if (request.Customer.IdParte != Guid.Empty)
            {
                var customer = await GetParteRoleByType(request.Customer.IdParte, eTipoParteRole.ClientePersona);
                domain.VentaRole.Add(new VentaRole 
                { 
                    IdTipoParteRole = customer.IdTipoParteRole,
                    IdParteRole = customer.IdParteRole,
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
        private async Task<ParteRole> GetParteRoleByType(Guid part, eTipoParteRole tipoParteRole)
        {
            var matches = _contex.ParteRole.Where(x => x.IdParte == part && x.IdTipoParteRole == (int)tipoParteRole && x.FechaFinal == null);
            if (matches.Any())
                return await Task.FromResult(matches.FirstOrDefault());
            else
            {
                var domain = new ParteRole()
                {
                    IdParte = part,
                    IdTipoParteRole = (int)tipoParteRole,
                    FechaInicial = DateTime.Now,
                };
                _contex.ParteRole.Add(domain);
                await _contex.SaveChangesAsync();
                return domain;
            }
        }
    }
}
