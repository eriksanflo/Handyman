using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class TipoPropositoContacto
    {
        public TipoPropositoContacto()
        {
            DireccionPostalParte = new HashSet<DireccionPostalParte>();
            PropositoContacto = new HashSet<PropositoContacto>();
        }

        public int IdTipoPropositoContacto { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<DireccionPostalParte> DireccionPostalParte { get; set; }
        public virtual ICollection<PropositoContacto> PropositoContacto { get; set; }
    }
}
