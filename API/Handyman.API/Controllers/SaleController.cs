using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class SaleController : BaseApiController
    {
        [HttpPut]
        public async Task<IActionResult> Save()
        {
            return Ok();
        }

        [HttpPut]
        [Route("Qoutation")]
        public async Task<IActionResult> SaveQuotation()
        {
            return Ok();
        }

        [HttpPost]
        [Route("Qoutation/{id}/TransformToSale")]
        public async Task<IActionResult> TransformToSale(int id)
        {
            return Ok();
        }
    }
}
