using Handyman.Service.Handler.Commands.Part;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Part
{
    public class PartAcceptedConditionHandler : IRequestHandler<AcceptedConditionCommand, AcceptConditionResult>
    {
        private readonly IApplicationDbContext _contex;

        public PartAcceptedConditionHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<AcceptConditionResult> Handle(AcceptedConditionCommand request, CancellationToken cancellationToken)
        {
            var result = new AcceptConditionResult();
            try
            {
                var _matched = _contex.ParteAceptaTermino?.FirstOrDefault(x => x.IdParte == request.IdParte);
                result.ResultadoTerminos = new ParteAceptaTerminosInfo
                {
                    IdParte = _matched?.IdParte ?? Guid.Empty,
                    AceptaTerminos = _matched?.AceptaTerminos ?? false,
                    Fecha = _matched?.Fecha ?? DateTime.Now,
                };
                result.SetSuccess();
            }
            catch (Exception ex)
            {
                result.BuildBadRequest(ex.Message);
            }
            return result;
        }
    }
}
