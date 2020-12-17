using System;
using System.Collections.Generic;
using System.Text;

namespace Handyman.Service.Handler.Result
{
    public class CodigoPostalMatched
    {
        public int IdCodigoPostal { get; set; }
        public int IdPais { get; set; }
        public string Pais { get; set; }
        public int IdRegion1 { get; set; }
        public string Region1 { get; set; }
        public int IdRegion2 { get; set; }
        public string Region2 { get; set; }
        public int? IdRegion3 { get; set; }
        public string Region3 { get; set; }
        public int? IdRegion4 { get; set; }
        public string Region4 { get; set; }
        public string CodigoPostal { get; set; }
        public bool Activo { get; set; }
    }
}
