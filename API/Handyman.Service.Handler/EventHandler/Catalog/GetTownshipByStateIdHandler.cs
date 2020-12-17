using Handyman.Service.Handler.Commands.Catalog;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Catalog
{
    public class GetTownshipByStateIdHandler : IRequestHandler<GetTownshipByStateIdCommand, GetTownshipByStateIdResult>
    {
        private readonly IApplicationDbContext _contex;
        public GetTownshipByStateIdHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<GetTownshipByStateIdResult> Handle(GetTownshipByStateIdCommand request, CancellationToken cancellationToken)
        {
            var response = new GetTownshipByStateIdResult();
            try
            {
                var matched = _contex.CodigoPostal
                    .Where(x => x.IdRegion1 == request.StateId)
                    .Select(x => new 
                    {
                        x.IdRegion1,
                        x.Region1,
                        x.IdRegion2,
                        x.Region2,
                    })
                    .Distinct();
                foreach (var pc in matched)
                {
                    response.PostalCode.Add(new Result.CodigoPostalMatched 
                    {
                        IdRegion1 = pc.IdRegion1,
                        IdRegion2 = pc.IdRegion2,
                        Region1 = pc.Region1,
                        Region2 = pc.Region2,
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
