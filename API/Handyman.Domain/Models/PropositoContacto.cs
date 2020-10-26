using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class PropositoContacto
    {
        public PropositoContacto()
        {
            DireccionPostalParte = new HashSet<DireccionPostalParte>();
            MedioContactoParte = new HashSet<MedioContactoParte>();
        }

        public int IdPropositoContacto { get; set; }
        public int IdTipoPropositoContacto { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        public virtual TipoPropositoContacto IdTipoPropositoContactoNavigation { get; set; }
        public virtual ICollection<DireccionPostalParte> DireccionPostalParte { get; set; }
        public virtual ICollection<MedioContactoParte> MedioContactoParte { get; set; }
    }
}
