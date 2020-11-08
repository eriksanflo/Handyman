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
    public class DeletePartContactHandler : IRequestHandler<PartContactIdCommand, BaseResult>
    {
        private readonly IApplicationDbContext _context;

        public DeletePartContactHandler(IApplicationDbContext contex) => _context = contex;

        public async Task<BaseResult> Handle(PartContactIdCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResult();
            try
            {
                var model = Get(request.ContactId);
                model.FechaFinal = DateTime.Now;
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
    }
}
