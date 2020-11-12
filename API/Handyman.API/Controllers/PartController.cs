using Handyman.Service.Handler.Commands.Part;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Handyman.API.Controllers
{
    public class PartController : BaseApiController
    {
        [HttpPut]
        public async Task<IActionResult> Save(CreatePartCommand cmd)
        {
            var result = Mediator.Send(cmd).Result;
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpDelete]
        [Route("{idParteRole}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cmd = new DeletePartCommand(id);
            var result = Mediator.Send(cmd).Result;
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        public async Task<IActionResult> Get(GetPartCommand cmd)
        {
            var result = Mediator.Send(cmd).Result;
            if (result.Success)
                return Ok(result.PartInfo);
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
