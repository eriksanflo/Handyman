using Handyman.Service.Handler.Commands.Catalog;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Handyman.API.Controllers
{
    public class CatalogController : BaseApiController
    {
        [HttpGet]
        [Route("Location/{postalCode}")]
        public async Task<IActionResult> FindMyLocation(string postalCode)
        {
            var cmd = new FindLocationByPostalCodeCommand(postalCode);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.Matched);
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        [Route("Location/State")]
        public async Task<IActionResult> GetStates()
        {
            var cmd = new GetStatesCommand();
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.PostalCode);
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        [Route("Location/state/{stateId}/township")]
        public async Task<IActionResult> GetTownshipByState(int stateId)
        {
            var cmd = new GetTownshipByStateIdCommand(stateId);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.PostalCode);
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        [Route("Location/township/{townId}/city")]
        public async Task<IActionResult> GetCityByTown(int townId)
        {
            var cmd = new GetCitiesByTownIdCommand(townId);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.PostalCode);
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
