using Microsoft.AspNetCore.Mvc;
using System;

namespace Handyman.API.Controllers
{
    public class DefaultController : BaseApiController
    {

        [HttpGet]
        public ActionResult Index()
        {
            return Ok($"It is working {DateTime.Now}");
        }
    }
}
