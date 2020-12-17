using System;

namespace Handyman.Service.Handler.Common.Info
{
    public class CardCreditCardPaymentInfo
    {
        public Guid IdParte { get; set; }
        public int IdTarjetaCliente { get; set; }
        public int IdTipoTarjeta { get; set; }
        public int IdRedTarjeta { get; set; }
        public int IdBanco { get; set; }
        public string TipoTarjeta { get; set; }
        public string RedTarjeta { get; set; }
        public string Banco { get; set; }
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Expiracion { get; set; }
        public string CVV { get; set; }
        public bool? IsAMEX { get; set; }
        public bool IsDefault { get; set; }
    }
}
