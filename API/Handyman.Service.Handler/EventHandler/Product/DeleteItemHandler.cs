using Handyman.Service.Handler.Commands.Product;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Product
{
    public class DeleteItemHandler : IRequestHandler<DeleteItemCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;
        public DeleteItemHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<BaseResult> Handle(DeleteItemCommand request, CancellationToken cancellationToken)
        {
            var result = new BaseResult();
            try
            {
                var domain = _contex.Item.Single(x => x.IdItem == request.IdItem);
                domain.Activo = false;
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
