using Handyman.Service.Handler.Commands.Product;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Handyman.API.Controllers
{
    public class ProductController : BaseApiController
    {
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

        [HttpPut]
        [Route("Category/{idCategory}/Item")]
        public async Task<IActionResult> SaveItem(int idCategory, ItemCommand cmd)
        {
            cmd.IdCategory = idCategory;
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpDelete]
        [Route("Item/{idItem}")]
        public async Task<IActionResult> DeleteItem(int idItem)
        {
            var result = await Mediator.Send(new DeleteItemCommand(idItem));
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpGet]
        [Route("Item/{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var result = await Mediator.Send(new GetItemCommand(id));
            if (result.Success)
                return Ok(result.ItemInfo);
            else
                return BadRequest(result.HttpResponse);
        }
    }
}
