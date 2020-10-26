using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class PagoRole
    {
        public int IdPagoRole { get; set; }
        public int? IdPago { get; set; }
        public int? IdParteRole { get; set; }
        public int? IdTipoParteRole { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }
        public DateTimeOffset? FechaRegistro { get; set; }

        public virtual Pago IdPagoNavigation { get; set; }
        public virtual ParteRole IdParteRoleNavigation { get; set; }
        public virtual TipoParteRole IdTipoParteRoleNavigation { get; set; }
    }
}
