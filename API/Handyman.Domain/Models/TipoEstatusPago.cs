using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class TipoEstatusPago
    {
        public TipoEstatusPago()
        {
            EstatusPago = new HashSet<EstatusPago>();
        }

        public int IdTipoEstatusPago { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<EstatusPago> EstatusPago { get; set; }
    }
}
