using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class AccesoProvider
    {
        public int IdAcceso { get; set; }
        public string Provider { get; set; }
        public string ApplicationId { get; set; }
        public string AppSecret { get; set; }
        public string AccessToken { get; set; }

        public virtual Accesos IdAccesoNavigation { get; set; }
    }
}
