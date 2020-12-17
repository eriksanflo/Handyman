using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Reporting
{
    public class GetSaleDescriptionCommand : IRequest<SaleDescriptionResult>
    {
        public int Id { get; set; }
        public GetSaleDescriptionCommand(int id)
        {
            Id = id;
        }
    }
    public class SaleDescriptionResult : BaseResult
    {
        public SaleDescriptionInfo Resume { get; set; }
    }
    public class SaleDescriptionInfo 
    {
        public string Customer { get; set; }
        public string Address { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string Description5 { get; set; }
        public List<string> ImagesList { get; set; }
    }
}
