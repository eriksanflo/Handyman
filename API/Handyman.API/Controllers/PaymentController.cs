using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class PaymentController : BaseApiController
    {
        [HttpPut]
        public async Task<IActionResult> Save()
        {
            return Ok();
        }
    }
}
