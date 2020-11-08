using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;
using System;

namespace Handyman.Service.Handler.Commands.Contact
{
    public class GetContactMethodPartCommand : IRequest<GetContactMethodPartResult>
    {
        public Guid PartId { get; set; }
        public int PorposeId { get; set; }
        public GetContactMethodPartCommand(Guid _partId, int _porposeId)
        {
            PartId = _partId;
            PorposeId = _porposeId;
        }
    }

    public class GetContactMethodPartResult : BaseResult
    {
        public ContactMethodPartInfo Contact { get; set; }
    }
}
