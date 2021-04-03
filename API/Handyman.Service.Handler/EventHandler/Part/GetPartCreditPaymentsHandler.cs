using Handyman.Service.Handler.Commands.Part;
using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Part
{
    public class GetPartCreditPaymentsHandler : IRequestHandler<GetPartCreditPaymentsCommand, GetParteCreditPaymentsResult>
    {
        private readonly IApplicationDbContext _contex;
        public GetPartCreditPaymentsHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<GetParteCreditPaymentsResult> Handle(GetPartCreditPaymentsCommand request, CancellationToken cancellationToken)
        {
            var result = new GetParteCreditPaymentsResult();
            try
            {
                var matched = _contex.TarjetaCliente
                    .Include(x => x.IdBancoNavigation)
                    .Include(x => x.IdRedTarjetaNavigation)
                    .Include(x => x.IdTipoTarjetaNavigation)
                    .Where(x => x.IdParte == request.PartId && x.FechaFin == null);
                result.CreditCards = new List<Common.Info.CardCreditCardPaymentInfo>();
                foreach (var _match in matched)
                {
                    result.CreditCards.Add(new CardCreditCardPaymentInfo()
                    {
                        IdParte = _match.IdParte,
                        IdTarjetaCliente = _match.IdTarjetaCliente,
                        IdBanco = _match.IdBanco,
                        Banco = _match.IdBancoNavigation.Nombre,
                        IdTipoTarjeta = _match.IdTipoTarjeta,
                        TipoTarjeta = _match.IdTipoTarjetaNavigation.Nombre,
                        IdRedTarjeta = _match.IdRedTarjeta,
                        RedTarjeta = _match.IdRedTarjetaNavigation.Nombre,
                        Titular = _match.Titular,
                        Numero = _match.Numero,
                        Expiracion = _match.Expiracion,
                        CVV = _match.Cvv,
                        IsAMEX = _match.IsAmex,
                        IsDefault = _match.IsDefault,
                    });
                }
                result.SetSuccess();
            }
            catch (Exception ex)
            {
                result.BuildBadRequest(ex.Message);
            }
            return await Task.FromResult(result);
        }
    }
}
