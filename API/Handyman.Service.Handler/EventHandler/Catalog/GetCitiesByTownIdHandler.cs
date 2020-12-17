using Handyman.Service.Handler.Commands.Catalog;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Catalog
{
    public class GetCitiesByTownIdHandler : IRequestHandler<GetCitiesByTownIdCommand, GetCitiesByTownIdResult>
    {
        private readonly IApplicationDbContext _contex;
        public GetCitiesByTownIdHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<GetCitiesByTownIdResult> Handle(GetCitiesByTownIdCommand request, CancellationToken cancellationToken)
        {
            var response = new GetCitiesByTownIdResult();
            try
            {
                var matched = _contex.CodigoPostal
                    .Where(x => x.IdRegion2 == request.TownId);
                foreach (var pc in matched)
                {
                    response.PostalCode.Add(new Result.CodigoPostalMatched
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
                response.SetSuccess();
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
