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
        public int IdItemCotizacion { get; set; }
        public int IdItem { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public decimal? Precio { get; set; }
        public bool Activo { get; set; }

        public virtual ItemCotizacion IdItemCotizacionNavigation { get; set; }
        public virtual Item IdItemNavigation { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalle { get; set; }
    }
}
