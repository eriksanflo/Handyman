using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class PostalController : BaseApiController
    {
        [HttpPut]
        [Route("Part/{idPart}/Address")]
        public async Task<IActionResult> Save(Guid idPart)
        {
            return Ok();
        }
    }
}
