using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;
using System;

namespace Handyman.Service.Handler.Commands.Part
{
    public class GetPartCommand : IRequest<GetPartResult>
    {
        public int IdParteRole { get; set; }
        public int IdTipoParteRole { get; set; }
        public Guid IdParte { get; set; }
    }

    public class GetPartResult : BaseResult
    {
        public PartResult PartInfo { get; set; }
    }
    public class PartResult
    {
        public int IdParteRole { get; set; }
        public int IdTipoParteRole { get; set; }
        public PersonInfo Person { get; set; }
        public OrganizacionInfo Company { get; set; }
    }
}
