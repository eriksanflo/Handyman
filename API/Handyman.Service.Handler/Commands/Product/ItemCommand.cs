using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Product
{
    public class ItemCommand : IRequest<BaseResult>
    {
        public int IdCategory { get; set; }
        public int IdProduct { get; set; }
        public int IdUnitSale { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public bool Active { get; set; }
        public List<PriceConfiguration> Prices { get; set; }
    }

    public class PriceConfiguration
    {
        public int Id { get; set; }
        public int IdItem { get; set; }
        public int IdItemCotizacion { get; set; }
        public int FromQuantity { get; set; }
        public int ToQuantity { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset FromDate { get; set; }
        public DateTimeOffset? ToDate { get; set; }
        public bool Active { get; set; }
    }
}
