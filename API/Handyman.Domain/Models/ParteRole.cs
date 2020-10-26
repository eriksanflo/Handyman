using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class ParteRole
    {
        public ParteRole()
        {
            PagoEstatus = new HashSet<PagoEstatus>();
            PagoRole = new HashSet<PagoRole>();
            VentaEstatus = new HashSet<VentaEstatus>();
            VentaRole = new HashSet<VentaRole>();
        }

        public int IdParteRole { get; set; }
        public Guid IdParte { get; set; }
        public int? IdTipoParteRole { get; set; }
        public DateTime? FechaInicial { get; set; }
        public DateTime? FechaFinal { get; set; }

        public virtual Parte IdParteNavigation { get; set; }
        public virtual TipoParteRole IdTipoParteRoleNavigation { get; set; }
        public virtual ICollection<PagoEstatus> PagoEstatus { get; set; }
        public virtual ICollection<PagoRole> PagoRole { get; set; }
        public virtual ICollection<VentaEstatus> VentaEstatus { get; set; }
        public virtual ICollection<VentaRole> VentaRole { get; set; }
    }
}
