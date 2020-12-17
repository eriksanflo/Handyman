using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class Item
    {
        public Item()
        {
            AsignacionParteItem = new HashSet<AsignacionParteItem>();
            ItemCotizacion = new HashSet<ItemCotizacion>();
            ItemPrecio = new HashSet<ItemPrecio>();
            VentaDetalle = new HashSet<VentaDetalle>();
        }

        public int IdItem { get; set; }
        public int? IdTipoItem { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }

        public virtual TipoItem IdTipoItemNavigation { get; set; }
        public virtual ItemServicio ItemServicio { get; set; }
        public virtual ICollection<AsignacionParteItem> AsignacionParteItem { get; set; }
        public virtual ICollection<ItemCotizacion> ItemCotizacion { get; set; }
        public virtual ICollection<ItemPrecio> ItemPrecio { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalle { get; set; }
    }
}
