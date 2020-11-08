using System;

namespace Handyman.Service.Handler.Common.Info
{
    public class PartContactInfo
    {
        public int IdDireccionPostalParte { get; set; }
        public Guid IdParte { get; set; }
        public int IdPropositoContacto { get; set; }
        public int IdCodigoPostal { get; set; }
        public string Calle { get; set; }
        public string EntreCalle { get; set; }
        public string YCalle { get; set; }
        public string NumeroExterior { get; set; }
        public string NumeroInterior { get; set; }
        public string Referencia { get; set; }
        public bool? Principal { get; set; }
    }
}
