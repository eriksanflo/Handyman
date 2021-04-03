using Handyman.Service.Handler.Result;
using MediatR;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Catalog
{
    public class FindConfigurationsCommand : IRequest<ConfigurationsResult>
    {
    }

    public class ConfigurationsResult : BaseResult
    {
        public List<ConfigurationInfo> Configs { get; set; }
    }

    public class ConfigurationInfo
    {
        public int IdConfiguration { get; set; }
        public string Nombre { get; set; }
        public string ActualizacionCode { get; set; }
    }
}
