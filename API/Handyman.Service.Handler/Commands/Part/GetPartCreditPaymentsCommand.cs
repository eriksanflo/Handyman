using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Part
{
    public class GetPartCreditPaymentsCommand : IRequest<GetParteCreditPaymentsResult>
    {
        public Guid PartId { get; private set; }
        public GetPartCreditPaymentsCommand(Guid id) => PartId = id;
    }

    public class GetParteCreditPaymentsResult : BaseResult
    {
        public List<CardCreditCardPaymentInfo> CreditCards { get; set; }
    }
}
