using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class TipoEstatusVenta
    {
        public TipoEstatusVenta()
        {
            EstatusVenta = new HashSet<EstatusVenta>();
        }

        public int IdTipoEstatusVenta { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<EstatusVenta> EstatusVenta { get; set; }
    }
}
