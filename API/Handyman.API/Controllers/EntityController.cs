using Handyman.Service.Handler.Commands.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Handyman.API.Controllers
{
    public class EntityController : BaseApiController
    {
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpPost]
        [Route("Register/Network")]
        public async Task<IActionResult> RegisterByExternal(RegisterWithNetworkCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        [Route("Authorization")]
        public async Task<IActionResult> Authorization(AuthenticateCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.TokenInfo);
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
