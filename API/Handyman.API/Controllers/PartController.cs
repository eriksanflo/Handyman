﻿using Handyman.Service.Handler.Commands.Part;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [Route("{id}")]
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

        [HttpPut]
        [Route("Card")]
        public async Task<IActionResult> SavePaymentMethod(CreatePartCreditCardCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        [Route("Card/{idParte}")]
        public async Task<IActionResult> GetPaymentMethods(Guid idParte)
        {
            var cmd = new GetPartCreditPaymentsCommand(idParte);
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok(result.CreditCards);
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpDelete]
        [Route("Card/{id}")]
        public async Task<IActionResult> DeletePaymentMethod(int id)
        {
            var cmd = new DeletePartCreditCardCommand(id);
            var result = Mediator.Send(cmd).Result;
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
