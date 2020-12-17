using Handyman.Service.Handler.Result;
using MediatR;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Catalog
{
    public class FindLocationByPostalCodeCommand : IRequest<FindLocationByPostalCodeResult>
    {
        public string PostalCode { get; set; }
        public FindLocationByPostalCodeCommand(string postalCode) => PostalCode = postalCode;
    }
    public class FindLocationByPostalCodeResult : BaseResult
    {
        public List<CodigoPostalMatched> Matched { get; set; }
    }
}
