using Handyman.Service.Handler.Result;
using MediatR;

namespace Handyman.Service.Handler.Commands.Product
{
    public class CategoryCommand : IRequest<BaseResult>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public bool IsCategory { get; set; }
        public bool Active { get; set; }
    }
}
