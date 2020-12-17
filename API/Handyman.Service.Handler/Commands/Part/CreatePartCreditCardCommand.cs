using Handyman.Service.Handler.Result;
using MediatR;
using System;

namespace Handyman.Service.Handler.Commands.Part
{
    public class CreatePartCreditCardCommand : IRequest<BaseResult>
    {
        public int IdTarjetaCliente { get; set; }
        public Guid IdParte { get; set; }
        public int IdTipoTarjeta { get; set; }
        public int IdRedTarjeta { get; set; }
        public int IdBanco { get; set; }
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Expiracion { get; set; }
        public string CVV { get; set; }
        public bool? IsAMEX { get; set; }
        public bool IsDefault { get; set; }
    }
}
