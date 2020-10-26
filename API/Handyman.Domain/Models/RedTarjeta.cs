using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class RedTarjeta
    {
        public RedTarjeta()
        {
            TarjetaCliente = new HashSet<TarjetaCliente>();
        }

        public int IdRedTarjeta { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<TarjetaCliente> TarjetaCliente { get; set; }
    }
}
