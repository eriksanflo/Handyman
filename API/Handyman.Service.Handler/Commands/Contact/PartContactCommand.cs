using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;
using System;

namespace Handyman.Service.Handler.Commands.Contact
{
    public class PartContactCommand : PartContactInfo, IRequest<BaseResult>
    {
        public int IdTipoPropositoContacto { get; set; }

        public DateTimeOffset FechaInicial { get; set; }

        public DateTimeOffset? FechaFinal { get; set; }
    }
}
