using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;
using System;

namespace Handyman.Service.Handler.Commands.Contact
{
    public class PartContactByPorposeCommand : IRequest<GetPartContactResult>
    {
        public Guid ID { get; set; }
        public int PorposeType { get; set; }
        public PartContactByPorposeCommand(Guid _id, int _porposeType)
        {
            ID = _id;
            PorposeType = _porposeType;
        }
    }

    public class GetPartContactResult : BaseResult
    {
        public PartAddress Address { get; set; }
    }

    public class PartAddress : PartContactInfo
    {
        public int IdPais { get; set; }
        public string Pais { get; set; }
        public int IdRegion1 { get; set; }
        public string Region1 { get; set; }
        public int IdRegion2 { get; set; }
        public string Region2 { get; set; }
        public int? IdRegion3 { get; set; }
        public string Region3 { get; set; }
        public string CodigoPostal { get; set; }
    }
}
