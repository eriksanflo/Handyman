using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Handyman.Service.Handler.Commands.Payment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class PaymentController : BaseApiController
    {
        [HttpPut]
        public async Task<IActionResult> Save(CreatePaymentCommand command)
        {
            var result = await Mediator.Send(command);
            if (result.Success)
                return Ok(result.Payment);
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
