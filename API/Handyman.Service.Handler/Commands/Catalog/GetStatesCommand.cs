using Handyman.Service.Handler.Result;
using MediatR;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Catalog
{
    public class GetStatesCommand : IRequest<GetStatesResult>
    {
        
    }

    public class GetStatesResult : BaseResult
    {
        public List<CodigoPostalMatched> PostalCode { get; set; }
    }
}
