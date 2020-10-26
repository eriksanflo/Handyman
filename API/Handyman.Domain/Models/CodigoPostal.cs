using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class CodigoPostal
    {
        public CodigoPostal()
        {
            DireccionPostalParte = new HashSet<DireccionPostalParte>();
        }

        public int IdCodigoPostal { get; set; }
        public int IdPais { get; set; }
        public string Pais { get; set; }
        public int IdRegion1 { get; set; }
        public string Region1 { get; set; }
        public int IdRegion2 { get; set; }
        public string Region2 { get; set; }
        public int? IdRegion3 { get; set; }
        public string Region3 { get; set; }
        public int? IdRegion4 { get; set; }
        public string Region4 { get; set; }
        public string CodigoPostal1 { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<DireccionPostalParte> DireccionPostalParte { get; set; }
    }
}
