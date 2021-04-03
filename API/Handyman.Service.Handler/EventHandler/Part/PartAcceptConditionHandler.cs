using Handyman.Service.Handler.Commands.Part;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Part
{
    public class PartAcceptConditionHandler : IRequestHandler<AcceptConditionCommand, AcceptConditionResult>
    {
        private readonly IApplicationDbContext _contex;

        public PartAcceptConditionHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<AcceptConditionResult> Handle(AcceptConditionCommand request, CancellationToken cancellationToken)
        {
            var result = new AcceptConditionResult();
            try
            {
                var exists = _contex.ParteAceptaTermino.Any(x => x.IdParte == request.IdParte);
                var domain =
                    exists ?
                    _contex.ParteAceptaTermino.Single(x => x.IdParte == request.IdParte) :
                    new Domain.Models.ParteAceptaTermino();

                domain.IdParte = request.IdParte;
                domain.AceptaTerminos = request.AceptaTerminos;
                domain.Fecha = request.Fecha;

                if (exists)
                    await _contex.SaveChangesAsync();
                else
                {
                    _contex.ParteAceptaTermino.Add(domain);
                    await _contex.SaveChangesAsync();
                }

                result.ResultadoTerminos = new ParteAceptaTerminosInfo
                {
                    IdParte = domain.IdParte,
                    AceptaTerminos = domain.AceptaTerminos,
                    Fecha = domain.Fecha,
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
