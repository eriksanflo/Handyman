using System;
using System.Collections.Generic;

namespace Handyman.Domain.Models
{
    public partial class Persona
    {
        public Guid IdParte { get; set; }
        public string Codigo { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string NombrePrimario { get; set; }
        public string NombreSecundario { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public DateTimeOffset? FechaCreacion { get; set; }
        public DateTimeOffset? FechaModificacion { get; set; }
        public string TituloActual { get; set; }
        public string Genero { get; set; }
        public decimal? Estatura { get; set; }
        public decimal? Peso { get; set; }
        public bool? Activo { get; set; }

        public virtual Parte IdParteNavigation { get; set; }
    }
}
