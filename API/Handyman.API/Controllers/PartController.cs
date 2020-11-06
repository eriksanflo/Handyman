using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class PartController : BaseApiController
    {
        [HttpPut]
        [Route("Parte")]
        public async Task<IActionResult> Save()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("Parte")]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}
