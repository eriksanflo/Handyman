using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class ItemPrecio
    {
        public ItemPrecio()
        {
            VentaDetalle = new HashSet<VentaDetalle>();
        }

        public int IdItemPrecio { get; set; }
        public int IdItem { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public TimeSpan? HoraInicial { get; set; }
        public TimeSpan? HoraFinal { get; set; }
        public decimal? Precio { get; set; }
        public bool Activo { get; set; }

        public virtual Item IdItemNavigation { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalle { get; set; }
    }
}
