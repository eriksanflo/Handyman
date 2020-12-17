using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class Venta
    {
        public Venta()
        {
            VentaDetalle = new HashSet<VentaDetalle>();
            VentaEstatus = new HashSet<VentaEstatus>();
            VentaRole = new HashSet<VentaRole>();
        }

        public int IdVenta { get; set; }
        public int IdTipoVenta { get; set; }
        public string Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTimeOffset? FechaRegistro { get; set; }

        public virtual VentaEvaluacion VentaEvaluacion { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalle { get; set; }
        public virtual ICollection<VentaEstatus> VentaEstatus { get; set; }
        public virtual ICollection<VentaRole> VentaRole { get; set; }
    }
}
