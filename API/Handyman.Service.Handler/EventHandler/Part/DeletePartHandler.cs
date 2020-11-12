using Handyman.Service.Handler.Commands.Part;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Part
{
    public class DeletePartHandler : IRequestHandler<DeletePartCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;

        public DeletePartHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<BaseResult> Handle(DeletePartCommand request, CancellationToken cancellationToken)
        {
            var result = new BaseResult();
            try
            {
                var domain = _contex.PagoRole.Single(x => x.IdParteRole == request.IdParteRole);
                domain.FechaFinal = DateTime.Now;
                await _contex.SaveChangesAsync();
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
