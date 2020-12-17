using Handyman.Service.Handler.Commands.Catalog;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Catalog
{
    public class GetStatesHandler : IRequestHandler<GetStatesCommand, GetStatesResult>
    {
        private readonly IApplicationDbContext _contex;
        public GetStatesHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<GetStatesResult> Handle(GetStatesCommand request, CancellationToken cancellationToken)
        {
            var response = new GetStatesResult();
            try
            {
                var states = _contex.CodigoPostal
                    .Select(x => new
                    {
                        IdRegion1 = x.IdRegion1,
                        Region1 = x.Region1,
                    }).Distinct();
                foreach (var state in states)
                {
                    response.PostalCode.Add(new Result.CodigoPostalMatched 
                    {
                        IdRegion1 = state.IdRegion1,
                        Region1 = state.Region1,
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
