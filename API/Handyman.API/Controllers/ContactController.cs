using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class ContactController : BaseApiController
    {
        [HttpPut]
        [Route("Parte/{idPart}/Contact")]
        public async Task<IActionResult> Save(Guid idPart)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("Parte/{idPart}/Contact")]
        public async Task<IActionResult> Delete(Guid idPart)
        {
            return Ok();
        }

        [HttpGet]
        [Route("Parte/{idPart}/Contact")]
        public async Task<IActionResult> GetAll(Guid idPart)
        {
            return Ok();
        }
    }
}
