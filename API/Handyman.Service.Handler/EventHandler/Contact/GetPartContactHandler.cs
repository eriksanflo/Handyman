using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Contact;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Contact
{
    public class GetPartContactHandler : IRequestHandler<PartContactByPorposeCommand, GetPartContactResult>
    {
        private readonly IApplicationDbContext _context;

        public GetPartContactHandler(IApplicationDbContext contex) => _context = contex;

        public async Task<GetPartContactResult> Handle(PartContactByPorposeCommand request, CancellationToken cancellationToken)
        {
            var response = new GetPartContactResult();
            try
            {
                var matched = _context
                    .DireccionPostalParte
                    .Include(x => x.IdCodigoPostalNavigation)
                    .Where(x => x.IdParte == request.ID && x.IdPropositoContacto == request.PorposeType && x.FechaFinal == null);

                if (matched.Any())
                {
                    var model = matched.FirstOrDefault();
                    response.Address = BuildAddress(matched.FirstOrDefault());
                }
                else
                    response.BuildBadRequest("No existe dirección postal");
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return await Task.FromResult(response);
        }
        private PartAddress BuildAddress(DireccionPostalParte model)
        {
            var _address = new PartAddress
            {
                IdParte = model.IdParte,
                IdDireccionPostalParte = model.IdDireccionPostalParte,
                IdPropositoContacto = model.IdPropositoContacto,
                IdPais = model.IdCodigoPostalNavigation.IdPais,
                IdRegion1 = model.IdCodigoPostalNavigation.IdRegion1,
                IdRegion2 = model.IdCodigoPostalNavigation.IdRegion2,
                IdRegion3 = model.IdCodigoPostalNavigation.IdRegion3,
                IdCodigoPostal = model.IdCodigoPostal,
                Pais = model.IdCodigoPostalNavigation.Pais,
                Region1 = model.IdCodigoPostalNavigation.Region1,
                Region2 = model.IdCodigoPostalNavigation.Region2,
                Region3 = model.IdCodigoPostalNavigation.Region3,
                CodigoPostal = model.IdCodigoPostalNavigation.CodigoPostal1,
                Calle = model.Calle,
                EntreCalle = model.EntreCalle,
                YCalle = model.Ycalle,
                NumeroExterior = model.NumeroExterior,
                NumeroInterior = model.NumeroInterior,
                Principal = model.Principal,
                Referencia = model.Referencia,
            };
            return _address;
        }
    }
}
