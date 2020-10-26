using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class Pago
    {
        public Pago()
        {
            PagoEstatus = new HashSet<PagoEstatus>();
            PagoRole = new HashSet<PagoRole>();
            VentaDetalle = new HashSet<VentaDetalle>();
        }

        public int IdPago { get; set; }
        public int IdTarjetaCliente { get; set; }
        public string Folio { get; set; }
        public Guid? IdParteCliente { get; set; }
        public string NumeroAutorizacion { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteRecibido { get; set; }
        public string Estatus { get; set; }
        public DateTimeOffset? FechaRegistro { get; set; }
        public string Observaciones { get; set; }

        public virtual Parte IdParteClienteNavigation { get; set; }
        public virtual TarjetaCliente IdTarjetaClienteNavigation { get; set; }
        public virtual ICollection<PagoEstatus> PagoEstatus { get; set; }
        public virtual ICollection<PagoRole> PagoRole { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalle { get; set; }
    }
}
