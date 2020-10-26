using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class MedioContactoParte
    {
        public int IdMedioContactoParte { get; set; }
        public int IdTipoPropositoContacto { get; set; }
        public int IdPropositoContacto { get; set; }
        public Guid IdParte { get; set; }
        public string Contacto { get; set; }
        public bool Principal { get; set; }
        public DateTimeOffset FechaInicial { get; set; }
        public DateTimeOffset? FechaFinal { get; set; }

        public virtual Parte IdParteNavigation { get; set; }
        public virtual PropositoContacto IdPropositoContactoNavigation { get; set; }
    }
}
