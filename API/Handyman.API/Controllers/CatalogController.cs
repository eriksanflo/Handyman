using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Handyman.API.Controllers
{
    public class CatalogController : BaseApiController
    {
        [HttpGet]
        [Route("Location/{postalCode}")]
        public async Task<IActionResult> FindMyLocation(string postalCode)
        {
            return Ok();
        }

        [HttpGet]
        [Route("Location/State")]
        public async Task<IActionResult> GetStates()
        {
            return Ok();
        }

        [HttpGet]
        [Route("Location/state/{stateId}/township")]
        public async Task<IActionResult> GetTownshipByState(int stateId)
        {
            return Ok();
        }

        [HttpGet]
        [Route("Location/township/{townId}/city")]
        public async Task<IActionResult> GetCityByTown(int townId)
        {
            return Ok();
        }
    }
}
