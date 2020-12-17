using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Payment;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Payment
{
    public class CreatePaymentHandler : IRequestHandler<CreatePaymentCommand, CreatedPaymentResult>
    {
        private readonly IApplicationDbContext _contex;
        public CreatePaymentHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<CreatedPaymentResult> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            var response = new CreatedPaymentResult();
            try
            {
                var payment = BuildPayment(request);
                _contex.Pago.Add(payment);
                await _contex.SaveChangesAsync();
                payment.Folio = GenerateFolio(payment.IdPago);
                await _contex.SaveChangesAsync();
                response.Payment = new PaymentCreated
                {
                    PaymentId = payment.IdPago
                };
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }

        private Pago BuildPayment(CreatePaymentCommand request)
        {
            var payment = new Pago()
            {
                Folio = "Temporary",
                Estatus = "A",
                Importe = request.Amount,
                FechaRegistro = DateTime.Now,
                Observaciones = request.Note,
                //IdParteCliente = request.CustomerKey,
            };
            
            if (request.CustomerCardId > 0)
            {
                payment.IdTarjetaCliente = request.CustomerCardId;
            }
            //else if (request.Transfer != null)
            //{
            //    payment.id
            //}
            
            return payment;
        }
        private string GenerateFolio(int id)
        {
            var length = $"00000000{id}";
            return length.Substring(length.Length - 8);
        }
    }
}
