using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class TarjetaCliente
    {
        public TarjetaCliente()
        {
            Pago = new HashSet<Pago>();
            Venta = new HashSet<Venta>();
        }

        public int IdTarjetaCliente { get; set; }
        public Guid IdParte { get; set; }
        public int IdTipoTarjeta { get; set; }
        public int IdRedTarjeta { get; set; }
        public int IdBanco { get; set; }
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Expiracion { get; set; }
        public string Cvv { get; set; }
        public bool? IsAmex { get; set; }
        public bool IsDefault { get; set; }
        public DateTimeOffset FechaInicio { get; set; }
        public DateTimeOffset? FechaFin { get; set; }

        public virtual Banco IdBancoNavigation { get; set; }
        public virtual Parte IdParteNavigation { get; set; }
        public virtual RedTarjeta IdRedTarjetaNavigation { get; set; }
        public virtual TipoTarjeta IdTipoTarjetaNavigation { get; set; }
        public virtual ICollection<Pago> Pago { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
