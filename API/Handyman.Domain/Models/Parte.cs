using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class Parte
    {
        public Parte()
        {
            Accesos = new HashSet<Accesos>();
            AsignacionParteItem = new HashSet<AsignacionParteItem>();
            CuentaBancaria = new HashSet<CuentaBancaria>();
            DireccionPostalParte = new HashSet<DireccionPostalParte>();
            MedioContactoParte = new HashSet<MedioContactoParte>();
            Pago = new HashSet<Pago>();
            ParteRole = new HashSet<ParteRole>();
            TarjetaCliente = new HashSet<TarjetaCliente>();
        }

        public Guid IdParte { get; set; }

        public virtual Organizacion Organizacion { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ICollection<Accesos> Accesos { get; set; }
        public virtual ICollection<AsignacionParteItem> AsignacionParteItem { get; set; }
        public virtual ICollection<CuentaBancaria> CuentaBancaria { get; set; }
        public virtual ICollection<DireccionPostalParte> DireccionPostalParte { get; set; }
        public virtual ICollection<MedioContactoParte> MedioContactoParte { get; set; }
        public virtual ICollection<Pago> Pago { get; set; }
        public virtual ICollection<ParteRole> ParteRole { get; set; }
        public virtual ICollection<TarjetaCliente> TarjetaCliente { get; set; }
    }
}
