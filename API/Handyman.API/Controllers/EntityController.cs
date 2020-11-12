using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class EntityController : BaseApiController
    {
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register()
        {
            return Ok();
        }

        [HttpPost]
        [Route("Register/Network")]
        public async Task<IActionResult> RegisterByExternal()
        {
            return Ok();
        }

        [HttpGet]
        [Route("Authorization")]
        public async Task<IActionResult> Authorization()
        {
            return Ok();
        }
    }
}
