using Handyman.Service.Handler.Result;
using MediatR;
using System;

namespace Handyman.Service.Handler.Commands.Contact
{
    public class PartContactIdCommand : IRequest<BaseResult>
    {
        public Guid ID { get; set; }
        public int ContactId { get; set; }
        public PartContactIdCommand(Guid _id, int _contactId)
        {
            ID = _id;
            ContactId = _contactId;
        }
    }
}
