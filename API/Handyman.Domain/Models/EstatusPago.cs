using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class EstatusPago
    {
        public EstatusPago()
        {
            PagoEstatus = new HashSet<PagoEstatus>();
        }

        public int IdEstatusPago { get; set; }
        public string Nombre { get; set; }
        public int? IdTipoEstatusPago { get; set; }
        public string TipoEstatus { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<PagoEstatus> PagoEstatus { get; set; }
    }
}
