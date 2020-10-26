using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class ItemCotizacion
    {
        public int IdItemCotizacion { get; set; }
        public int IdItem { get; set; }
        public int IdUnidadCotizacion { get; set; }
        public DateTimeOffset? FechaInicial { get; set; }
        public DateTimeOffset? FechaFinal { get; set; }

        public virtual Item IdItemNavigation { get; set; }
        public virtual UnidadCotizacion IdUnidadCotizacionNavigation { get; set; }
    }
}
