using Handyman.Service.Handler.Result;
using MediatR;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Catalog
{
    public class GetCitiesByTownIdCommand : IRequest<GetCitiesByTownIdResult>
    {
        public int TownId { get; set; }
        public GetCitiesByTownIdCommand(int id) => TownId = id;
    }
    public class GetCitiesByTownIdResult : BaseResult
    {
        public List<CodigoPostalMatched> PostalCode { get; set; }
    }
}
