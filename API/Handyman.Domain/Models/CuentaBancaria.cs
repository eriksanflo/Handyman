using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class CuentaBancaria
    {
        public int IdCuentaBancaria { get; set; }
        public Guid IdParte { get; set; }
        public int IdBanco { get; set; }
        public string Numero { get; set; }
        public string Clabe { get; set; }
        public bool Activo { get; set; }

        public virtual Banco IdBancoNavigation { get; set; }
        public virtual Parte IdParteNavigation { get; set; }
    }
}
