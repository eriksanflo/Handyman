using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Handyman.Service.Handler.Commands.Reporting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class ReportingController : BaseApiController
    {
        [HttpGet]
        [Route("Sales/SaleDescription/{id}")]
        public async Task<IActionResult> SaveCategory(int id)
        {
            var cmd = new GetSaleDescriptionCommand(id);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.Resume);
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
