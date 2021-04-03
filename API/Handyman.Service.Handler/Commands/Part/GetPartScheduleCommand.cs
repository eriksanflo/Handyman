using MediatR;
using System;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Part
{
    public class GetPartScheduleCommand : IRequest<PartScheduleResult>
    {
        public string IdParte { get; set; }
        public GetPartScheduleCommand(string _idParte) => IdParte = _idParte;
    }

    public class PartScheduleResult
    {
        public List<PartScheduleItem> ListItems { get; set; }
        public PartScheduleResult()
        {
            ListItems = new List<PartScheduleItem>();
        }
    }

    public class PartScheduleItem
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
        public DateTime FechaCompromiso { get; set; }
    }
}
