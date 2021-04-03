using System;

namespace Handyman.Domain.Procedures
{
    public class PartScheduleResult
    {
        public int IdParteRole { get; set; }
        public int IdVenta { get; set; }
        public int IdTipoVenta { get; set; }
        public int IdTipoItem { get; set; }
        public int IdItem { get; set; }
        public int? IdItemPrecio { get; set; }
        public string Folio { get; set; }
        public string TipoItem { get; set; }
        public string Item { get; set; }
        public string Observaciones { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public Guid IdParte { get; set; }
        public DateTimeOffset FechaCompromiso { get; set; }
    }
}
