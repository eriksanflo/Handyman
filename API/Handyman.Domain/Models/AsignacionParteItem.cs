using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class AsignacionParteItem
    {
        public int IdAsignacionParteItem { get; set; }
        public Guid IdParte { get; set; }
        public int IdItem { get; set; }
        public bool? PuedeSerEmergente { get; set; }
        public string TipoEmergente { get; set; }
        public decimal? ImporteIncremento { get; set; }
        public DateTimeOffset? FechaInicial { get; set; }
        public DateTimeOffset? FechaFinal { get; set; }

        public virtual Item IdItemNavigation { get; set; }
        public virtual Parte IdParteNavigation { get; set; }
    }
}
