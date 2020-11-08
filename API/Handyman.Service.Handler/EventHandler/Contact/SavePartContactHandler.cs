using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Contact;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Contact
{
    public class SavePartContactHandler : IRequestHandler<PartContactCommand, BaseResult>
    {
        private readonly IApplicationDbContext _context;

        public SavePartContactHandler(IApplicationDbContext contex)
        {
            _context = contex;
        }

        public async Task<BaseResult> Handle(PartContactCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResult();
            try
            {
                var isNew = request.IdDireccionPostalParte <= 0;
                var model = isNew ? new DireccionPostalParte() : Get(request.IdDireccionPostalParte);
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

        private DireccionPostalParte Get(int id)
        {
            return _context
                .DireccionPostalParte
                .Include(x => x.IdCodigoPostalNavigation)
                .Single(x => x.IdDireccionPostalParte == id);
        }
    
        private void Attach(DireccionPostalParte model, PartContactCommand cmd)
        {
            if (cmd.IdDireccionPostalParte > 0)
                model.IdDireccionPostalParte = cmd.IdDireccionPostalParte;

            if (cmd.IdDireccionPostalParte <= 0)
                model.FechaInicial = DateTime.Now;

            model.IdParte = cmd.IdParte;
            model.IdTipoPropositoContacto = cmd.IdTipoPropositoContacto;
            model.IdPropositoContacto = cmd.IdPropositoContacto;
            model.IdCodigoPostal = cmd.IdCodigoPostal;
            model.Calle = cmd.Calle;
            model.EntreCalle = cmd.EntreCalle;
            model.Ycalle = cmd.YCalle;
            model.NumeroExterior = cmd.NumeroExterior;
            model.NumeroInterior = cmd.NumeroInterior;
            model.Referencia = cmd.Referencia;
            model.Principal = cmd.Principal;

        }
    }
}
