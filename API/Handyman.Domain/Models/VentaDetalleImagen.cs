using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class VentaDetalleImagen
    {
        public int IdVentaDetalleImagen { get; set; }
        public int IdVentaDetalle { get; set; }
        public string ImagenUrl { get; set; }

        public virtual VentaDetalle IdVentaDetalleNavigation { get; set; }
    }
}
