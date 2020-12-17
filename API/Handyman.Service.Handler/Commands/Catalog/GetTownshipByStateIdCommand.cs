using Handyman.Service.Handler.Result;
using MediatR;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Catalog
{
    public class GetTownshipByStateIdCommand : IRequest<GetTownshipByStateIdResult>
    {
        public int StateId { get; set; }
        public GetTownshipByStateIdCommand(int id) => StateId = id;
    }

    public class GetTownshipByStateIdResult : BaseResult
    {
        public List<CodigoPostalMatched> PostalCode { get; set; }
    }
}
