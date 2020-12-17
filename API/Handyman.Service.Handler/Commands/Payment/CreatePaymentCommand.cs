using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Payment
{
    public class CreatePaymentCommand : IRequest<CreatedPaymentResult>
    {
        public Guid CustomerKey { get; set; }
        public int CustomerCardId { get; set; }
        public int UserRole { get; set; }
        public List<int> SalesId { get; set; }
        public TransferPayment Transfer { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
    }
    public class TransferPayment
    {
        public string Authorization { get; set; }
        public string Folio { get; set; }
        public string UrlRecipt { get; set; }
    }
    public class CreatedPaymentResult : BaseResult
    {
        public PaymentCreated Payment { get; set; }
    }
    public class PaymentCreated
    {
        public int PaymentId { get; set; }
    }
}
