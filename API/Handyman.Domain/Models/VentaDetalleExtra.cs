using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class VentaDetalleExtra
    {
        public int IdVentaDetalleExtra { get; set; }
        public int IdVentaDetalle { get; set; }
        public string Descripcion { get; set; }

        public virtual VentaDetalle IdVentaDetalleNavigation { get; set; }
    }
}
