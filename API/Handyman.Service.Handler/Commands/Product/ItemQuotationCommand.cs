using Handyman.Service.Handler.Result;
using MediatR;
using System;

namespace Handyman.Service.Handler.Commands.Product
{
    public class ItemQuotationCommand : IRequest<BaseResult>
    {
        public int IdItemQuotation { get; set; }
        public int IdItem { get; set; }
        public int IdUnitQuotation { get; set; }
        public DateTimeOffset InitialDate { get; set; }
        public DateTimeOffset FinalDate { get; set; }
    }
}
