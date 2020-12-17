using Handyman.Service.Handler.Commands.Catalog;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Catalog
{
    public class FindLocationByPostalCodeHandler : IRequestHandler<FindLocationByPostalCodeCommand, FindLocationByPostalCodeResult>
    {
        private readonly IApplicationDbContext _contex;
        public FindLocationByPostalCodeHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<FindLocationByPostalCodeResult> Handle(FindLocationByPostalCodeCommand request, CancellationToken cancellationToken)
        {
            var response = new FindLocationByPostalCodeResult();
            try
            {
                var matched = _contex.CodigoPostal.Where(x => x.CodigoPostal1 == request.PostalCode);
                foreach (var pc in matched)
                {
                    response.Matched.Add(new CodigoPostalMatched 
                    {
                        Activo = pc.Activo,
                        CodigoPostal = pc.CodigoPostal1,
                        IdCodigoPostal = pc.IdCodigoPostal,
                        IdPais = pc.IdPais,
                        IdRegion1 = pc.IdRegion1,
                        IdRegion2 = pc.IdRegion2,
                        IdRegion3 = pc.IdRegion3,
                        IdRegion4 = pc.IdRegion4,
                        Pais = pc.Pais,
                        Region1 = pc.Region1,
                        Region2 = pc.Region2,
                        Region3 = pc.Region3,
                        Region4 = pc.Region4,
                    });
                }
                return await Task.FromResult(response);
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }
    }
}
