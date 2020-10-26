using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class VentaEvaluacion
    {
        public int IdVenta { get; set; }
        public decimal? Estrellas { get; set; }
        public string Comentarios { get; set; }
        public bool? Activo { get; set; }

        public virtual Venta IdVentaNavigation { get; set; }
    }
}
