using Handyman.Service.Handler.Commands.Sale;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Handyman.API.Controllers
{
    public class SaleController : BaseApiController
    {
        [HttpPut]
        public async Task<IActionResult> Save(CreateSaleCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.SaleAffectedInfo);
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpPut]
        [Route("Qoutation")]
        public async Task<IActionResult> SaveQuotation(CreateSaleCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.SaleAffectedInfo);
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpPost]
        [Route("Qoutation/{id}/TransformToSale")]
        public async Task<IActionResult> TransformToSale(int id)
        {
            var cmd = new TransformToSaleCommand(id);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
