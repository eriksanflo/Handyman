using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class VentaEstatus
    {
        public int IdVentaEstatus { get; set; }
        public int? IdVenta { get; set; }
        public int? IdVentaDetalle { get; set; }
        public int? IdEstatusVenta { get; set; }
        public int? IdParteRole { get; set; }
        public DateTimeOffset? FechaRegistro { get; set; }

        public virtual EstatusVenta IdEstatusVentaNavigation { get; set; }
        public virtual ParteRole IdParteRoleNavigation { get; set; }
        public virtual VentaDetalle IdVentaDetalleNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
    }
}
