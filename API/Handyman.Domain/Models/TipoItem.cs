using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class TipoItem
    {
        public TipoItem()
        {
            Item = new HashSet<Item>();
            VentaDetalle = new HashSet<VentaDetalle>();
        }

        public int IdTipoItem { get; set; }
        public string Nombre { get; set; }
        public bool Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalle { get; set; }
    }
}
