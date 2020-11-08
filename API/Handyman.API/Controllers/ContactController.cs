using Handyman.Service.Handler.Commands.Contact;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Handyman.API.Controllers
{
    public class ContactController : BaseApiController
    {
        [HttpPut]
        [Route("Parte/{idPart}/Address")]
        public async Task<IActionResult> Save(Guid idPart, PartContactCommand cmd)
        {
            cmd.IdParte = idPart;
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpDelete]
        [Route("Parte/{idPart}/Address/{id}")]
        public async Task<IActionResult> Delete(Guid idPart, int id)
        {
            var cmd = new PartContactIdCommand(idPart, id);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        [Route("Parte/{idPart}/Address/{idPorpose}")]
        public async Task<IActionResult> Get(Guid idPart, int idPorpose)
        {
            var cmd = new PartContactByPorposeCommand(idPart, idPorpose);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.Address);
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpPut]
        [Route("Parte/{idPart}/Contact")]
        public async Task<IActionResult> Save(Guid idPart, CreateContactMethodPartCommand cmd)
        {
            cmd.IdParte = idPart;
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpDelete]
        [Route("Parte/{idPart}/Contact/{id}")]
        public async Task<IActionResult> DeleteContactMethod(Guid idPart, int id)
        {
            var cmd = new DeleteContactMethodPartCommand(id);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        [Route("Parte/{idPart}/Contact/{idPorpose}")]
        public async Task<IActionResult> GetContactMethod(Guid idPart, int idPorpose)
        {
            var cmd = new GetContactMethodPartCommand(idPart, idPorpose);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.Contact);
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
