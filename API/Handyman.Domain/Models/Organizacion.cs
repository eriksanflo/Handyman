using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class Organizacion
    {
        public Guid IdParte { get; set; }
        public string Nombre { get; set; }

        public virtual Parte IdParteNavigation { get; set; }
    }
}
