using Handyman.Service.Handler.Commands.Product;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Handyman.API.Controllers
{
    public class ProductController : BaseApiController
    {

        // PUT Create/Update Cagetory
        [HttpPut]
        [Route("Category")]
        public async Task<IActionResult> SaveCategory(CategoryCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        // GET GetAllCategories

        // GET GetCategory {IdCategory}

        // PUT Create/Update a Product

        // DELETE Disable a Product

        // GET GetProducts {IdCategory}

        // GET GetProduct {IdProduct}
    }
}
