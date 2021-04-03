using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Sale
{
    public class CreateSaleCommand : IRequest<CreateSaleResult>
    {
        public int SaleType { get; set; }
        public int IdCustomerCard { get; set; }
        public string IdOrder { get; set; }
        public CustomerInfo Customer { get; set; }
        public List<CreateSaleDetails> Details { get; set; }
        public List<PartDocumentInfo> Images { get; set; }
    }
    public class CreateSaleDetails
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductPriceId { get; set; }
        public int Line { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public DateTime SupplyDate { get; set; }
        public string Notes { get; set; }
    }
    public class CreateSaleResult : BaseResult
    {
        public SaleAffected SaleAffectedInfo { get; set; }
    }
    public class SaleAffected
    {
        public int SaleId { get; set; }
        public string Folio { get; set; }
    }
}
