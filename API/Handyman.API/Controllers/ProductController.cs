using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IMediator _mediator;
    }
}
