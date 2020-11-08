using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Contact;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Contact
{
    public class SaveContactMethodPartHandler : IRequestHandler<CreateContactMethodPartCommand, BaseResult>
    {
        private readonly IApplicationDbContext _context;

        public SaveContactMethodPartHandler(IApplicationDbContext contex) => _context = contex;

        public async Task<BaseResult> Handle(CreateContactMethodPartCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResult();
            try
            {
                var isNew = request.IdMedioContactoParte <= 0;
                var model = isNew ? new MedioContactoParte() : Get(request.IdMedioContactoParte);
                Attach(model, request);
                await _context.SaveChangesAsync();
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }
        private MedioContactoParte Get(int id)
        {
            return _context
                .MedioContactoParte
                .Single(x => x.IdMedioContactoParte == id);
        }

        private void Attach(MedioContactoParte model, CreateContactMethodPartCommand cmd)
        {
            if (cmd.IdMedioContactoParte > 0)
                model.IdMedioContactoParte = cmd.IdMedioContactoParte;

            if (cmd.IdMedioContactoParte <= 0)
                model.FechaInicial = DateTime.Now;

            model.IdParte = cmd.IdParte;
            model.IdTipoPropositoContacto = cmd.IdTipoPropositoContacto;
            model.IdPropositoContacto = cmd.IdPropositoContacto;
            model.Contacto = cmd.Contacto;
            model.Principal = cmd.Principal;
        }
    }
}
