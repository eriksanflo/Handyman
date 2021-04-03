using Handyman.Service.Handler.Commands.Catalog;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Catalog
{
    public class FindConfigurationsHandler : IRequestHandler<FindConfigurationsCommand, ConfigurationsResult>
    {
        private readonly IApplicationDbContext _contex;
        public FindConfigurationsHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<ConfigurationsResult> Handle(FindConfigurationsCommand request, CancellationToken cancellationToken)
        {
            var response = new ConfigurationsResult();
            try
            {
                response.Configs = _contex.Configuracion
                    .Select(x => new ConfigurationInfo 
                    { 
                        IdConfiguration = x.IdConfiguracion,
                        Nombre = x.Nombre,
                        ActualizacionCode = x.ActualizacionCode
                    })
                    .ToList();
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
