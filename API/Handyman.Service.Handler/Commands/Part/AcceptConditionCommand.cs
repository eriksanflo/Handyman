using Handyman.Service.Handler.Result;
using MediatR;
using System;

namespace Handyman.Service.Handler.Commands.Part
{
    public class AcceptConditionCommand : ParteAceptaTerminosInfo, IRequest<AcceptConditionResult>
    {
    }

    public class AcceptedConditionCommand : IRequest<AcceptConditionResult>
    {
        public Guid IdParte { get; set; }
        public AcceptedConditionCommand(Guid _idParte)
        {
            IdParte = _idParte;
        }
    }

    public class AcceptConditionResult : BaseResult
    {
        public ParteAceptaTerminosInfo ResultadoTerminos { get; set; }
    }

    public class ParteAceptaTerminosInfo
    {
        public Guid IdParte { get; set; }
        public DateTime Fecha { get; set; }
        public bool AceptaTerminos { get; set; }
    }
}
