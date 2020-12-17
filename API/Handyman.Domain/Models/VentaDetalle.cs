using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class VentaDetalle
    {
        public VentaDetalle()
        {
            VentaDetalleExtra = new HashSet<VentaDetalleExtra>();
            VentaDetalleImagen = new HashSet<VentaDetalleImagen>();
            VentaEstatus = new HashSet<VentaEstatus>();
        }

        public int IdVentaDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdItem { get; set; }
        public int IdTipoItem { get; set; }
        public int? IdItemPrecio { get; set; }
        public int? IdPago { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImportePagado { get; set; }
        public DateTimeOffset? FechaCompromiso { get; set; }
        public short? Secuencia { get; set; }
        public string Observaciones { get; set; }

        public virtual Item IdItemNavigation { get; set; }
        public virtual ItemPrecio IdItemPrecioNavigation { get; set; }
        public virtual Pago IdPagoNavigation { get; set; }
        public virtual TipoItem IdTipoItemNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
        public virtual ICollection<VentaDetalleExtra> VentaDetalleExtra { get; set; }
        public virtual ICollection<VentaDetalleImagen> VentaDetalleImagen { get; set; }
        public virtual ICollection<VentaEstatus> VentaEstatus { get; set; }
    }
}
