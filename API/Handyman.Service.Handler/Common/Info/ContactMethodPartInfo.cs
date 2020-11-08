using System;

namespace Handyman.Service.Handler.Common.Info
{
    public class ContactMethodPartInfo
    {
        public int IdMedioContactoParte { get; set; }
        public int IdPropositoContacto { get; set; }
        public Guid IdParte { get; set; }
        public string Contacto { get; set; }
        public bool Principal { get; set; }
    }
}
