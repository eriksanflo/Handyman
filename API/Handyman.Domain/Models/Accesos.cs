using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class Accesos
    {
        public int IdAcceso { get; set; }
        public Guid IdParte { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool? Activo { get; set; }

        public virtual Parte IdParteNavigation { get; set; }
    }
}
