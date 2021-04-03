namespace Handyman.Domain.Models
{
    public partial class Cargo
    {
        public string IdCargo { get; set; }
        public int IdVenta { get; set; }
        public decimal Importe { get; set; }
        public decimal? Reembolsado { get; set; }

        public virtual Venta IdVentaNavigation { get; set; }
    }
}
