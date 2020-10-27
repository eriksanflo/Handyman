using Microsoft.AspNetCore.Mvc;
using System;

namespace Handyman.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        [HttpGet]
        public ActionResult Index()
        {
            return Ok($"It is working {DateTime.Now}");
        }
    }
}
