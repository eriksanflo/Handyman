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
    public class DeletePartCreditCardHandler : IRequestHandler<DeletePartCreditCardCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;

        public DeletePartCreditCardHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<BaseResult> Handle(DeletePartCreditCardCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResult();
            try
            {
                var domain = _contex.TarjetaCliente.Single(x => x.IdTarjetaCliente == request.IdTarjetaCliente);
                domain.FechaFin = DateTime.Now;
                await _contex.SaveChangesAsync();
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }
    }
}
