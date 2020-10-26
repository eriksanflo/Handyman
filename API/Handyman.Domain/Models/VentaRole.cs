using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class VentaRole
    {
        public int IdVentaRole { get; set; }
        public int? IdVenta { get; set; }
        public int? IdParteRole { get; set; }
        public int? IdTipoParteRole { get; set; }
        public DateTimeOffset? FechaInicial { get; set; }
        public DateTimeOffset? FechaFinal { get; set; }

        public virtual ParteRole IdParteRoleNavigation { get; set; }
        public virtual TipoParteRole IdTipoParteRoleNavigation { get; set; }
        public virtual Venta IdVentaNavigation { get; set; }
    }
}
