using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Contact;
using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Contact
{
    public class GetContactMethodPartHandler : IRequestHandler<GetContactMethodPartCommand, GetContactMethodPartResult>
    {
        private readonly IApplicationDbContext _context;

        public GetContactMethodPartHandler(IApplicationDbContext contex) => _context = contex;

        public async Task<GetContactMethodPartResult> Handle(GetContactMethodPartCommand request, CancellationToken cancellationToken)
        {
            var response = new GetContactMethodPartResult();
            try
            {
                var matched = _context
                    .MedioContactoParte
                    .Where(x => x.IdParte == request.PartId && x.IdPropositoContacto == request.PorposeId && x.FechaFinal == null);

                if (matched.Any())
                {
                    var model = matched.FirstOrDefault();
                    response.Contact = BuildContact(matched.FirstOrDefault());
                }
                else
                    response.BuildBadRequest("No existe medio de contacto");
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return await Task.FromResult(response);
        }
        private ContactMethodPartInfo BuildContact(MedioContactoParte model)
        {
            var _contact = new ContactMethodPartInfo
            {
                IdParte = model.IdParte,
                IdMedioContactoParte = model.IdMedioContactoParte,
                IdPropositoContacto = model.IdPropositoContacto,
                Principal = model.Principal,
                Contacto = model.Contacto,
            };
            return _contact;
        }
    }
}
