using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class ParteAceptaTermino
    {
        public Guid IdParte { get; set; }
        public bool AceptaTerminos { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Parte IdParteNavigation { get; set; }
    }
}
