using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class TipoParteRole
    {
        public TipoParteRole()
        {
            PagoRole = new HashSet<PagoRole>();
            ParteRole = new HashSet<ParteRole>();
            VentaRole = new HashSet<VentaRole>();
        }

        public int IdTipoParteRole { get; set; }
        public string Nombre { get; set; }
        public bool? Usuario { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<PagoRole> PagoRole { get; set; }
        public virtual ICollection<ParteRole> ParteRole { get; set; }
        public virtual ICollection<VentaRole> VentaRole { get; set; }
    }
}
