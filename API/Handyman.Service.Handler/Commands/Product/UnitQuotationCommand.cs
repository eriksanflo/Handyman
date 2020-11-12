using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Product
{
    public class UnitQuotationCommand : IRequest<BaseResult>
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }
    }
}
