using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class UnidadCotizacion
    {
        public UnidadCotizacion()
        {
            ItemCotizacion = new HashSet<ItemCotizacion>();
        }

        public int IdUnidadCotizacion { get; set; }
        public string Abreviatura { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<ItemCotizacion> ItemCotizacion { get; set; }
    }
}
