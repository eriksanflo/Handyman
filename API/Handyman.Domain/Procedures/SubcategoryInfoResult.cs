namespace Handyman.Domain.Procedures
{
    public class SubcategoryInfoResult
    {
        public int IdTipoItem { get; set; }
        public int IdItem { get; set; }
        public int IdItemCotizacion { get; set; }
        public int IdUnidadCotizacion { get; set; }
        public int IdItemPrecio { get; set; }
        public string Nombre { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal Precio { get; set; }
    }
}
