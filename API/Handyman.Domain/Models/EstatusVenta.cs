using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class EstatusVenta
    {
        public EstatusVenta()
        {
            VentaEstatus = new HashSet<VentaEstatus>();
        }

        public int IdEstatusVenta { get; set; }
        public string Nombre { get; set; }
        public int? IdTipoEstatusVenta { get; set; }
        public string TipoEstatus { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<VentaEstatus> VentaEstatus { get; set; }
    }
}
