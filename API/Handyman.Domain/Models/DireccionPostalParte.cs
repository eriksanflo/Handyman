using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class DireccionPostalParte
    {
        public int IdDireccionPostalParte { get; set; }
        public Guid IdParte { get; set; }
        public int IdTipoPropositoContacto { get; set; }
        public int IdPropositoContacto { get; set; }
        public int IdCodigoPostal { get; set; }
        public string Calle { get; set; }
        public string EntreCalle { get; set; }
        public string Ycalle { get; set; }
        public string NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }
        public string Referencia { get; set; }
        public bool? Principal { get; set; }
        public DateTimeOffset FechaInicial { get; set; }
        public DateTimeOffset? FechaFinal { get; set; }

        public virtual CodigoPostal IdCodigoPostalNavigation { get; set; }
        public virtual Parte IdParteNavigation { get; set; }
        public virtual PropositoContacto IdPropositoContactoNavigation { get; set; }
        public virtual TipoPropositoContacto IdTipoPropositoContactoNavigation { get; set; }
    }
}
