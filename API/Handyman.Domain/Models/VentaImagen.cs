using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class VentaImagen
    {
        public int IdVentaImagen { get; set; }
        public int IdVenta { get; set; }
        public string Nombre { get; set; }
        public string Extension { get; set; }
        public byte[] Imagen { get; set; }

        public virtual Venta IdVentaNavigation { get; set; }
    }
}
