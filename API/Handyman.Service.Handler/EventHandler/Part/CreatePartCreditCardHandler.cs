using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Part;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Part
{
    public class CreatePartCreditCardHandler : IRequestHandler<CreatePartCreditCardCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;

        public CreatePartCreditCardHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<BaseResult> Handle(CreatePartCreditCardCommand request, CancellationToken cancellationToken)
        {
            var result = new BaseResult();
            try
            {
                var isNew = request.IdTarjetaCliente <= 0;
                var domain = isNew ? new TarjetaCliente() : _contex.TarjetaCliente.Single(x => x.IdTarjetaCliente == request.IdTarjetaCliente);
                domain.IdParte = request.IdParte;
                domain.IdTipoTarjeta = request.IdTipoTarjeta;
                domain.IdRedTarjeta = request.IdRedTarjeta;
                domain.IdBanco = request.IdBanco;
                domain.Titular = request.Titular;
                domain.Numero = request.Numero;
                domain.Expiracion = request.Expiracion;
                domain.Cvv = request.CVV;
                domain.IsAmex = request.IsAMEX;
                domain.IsDefault = request.IsDefault;
                if (isNew)
                {
                    domain.FechaInicio = DateTimeOffset.Now;
                    _contex.TarjetaCliente.Add(domain);
                }
                await _contex.SaveChangesAsync();
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
