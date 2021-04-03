using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Product
{
    public class GetSubcategoryInfoCommand : IRequest<SubcategoryInfoResult>
    {
        public int IdSubcategory { get; set; }
        public DateTimeOffset LocationDate { get; set; }
    }

    public class SubcategoryInfoResult : BaseResult
    {
        public List<SubcategoryInfo> SubcategoryInfo { get; set; }
    }
    public class SubcategoryInfo
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
