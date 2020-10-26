using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class Banco
    {
        public Banco()
        {
            TarjetaCliente = new HashSet<TarjetaCliente>();
        }

        public int IdBanco { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<TarjetaCliente> TarjetaCliente { get; set; }
    }
}
