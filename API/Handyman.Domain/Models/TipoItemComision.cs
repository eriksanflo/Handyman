namespace Handyman.Domain.Models
{
    public partial class TipoItemComision
    {
        public int IdTipoItemComision { get; set; }
        public int IdTipoItem { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public string TipoCalculo { get; set; }
        public decimal Valor { get; set; }
        public bool Activo { get; set; }

        public virtual TipoItem IdTipoItemNavigation { get; set; }
    }
}
