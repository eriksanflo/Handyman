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
    class DeleteContactMethodPartHandler : IRequestHandler<DeleteContactMethodPartCommand, BaseResult>
    {
        private readonly IApplicationDbContext _context;

        public DeleteContactMethodPartHandler(IApplicationDbContext contex) => _context = contex;

        public async Task<BaseResult> Handle(DeleteContactMethodPartCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResult();
            try
            {
                var model = Get(request.IdMedioContactoParte);
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
        private MedioContactoParte Get(int id) => _context.MedioContactoParte.Single(x => x.IdMedioContactoParte == id);
    }
}
