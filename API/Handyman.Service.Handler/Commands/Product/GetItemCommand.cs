using Handyman.Service.Handler.Result;
using MediatR;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Product
{
    public class GetItemCommand : IRequest<GetItemResult>
    {
        public int IdItem { get; set; }
        public GetItemCommand(int id) => IdItem = id;
    }

    public class GetItemResult : BaseResult
    {
        public ItemResult ItemInfo { get; set; }
    }
    public class ItemResult
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
}
