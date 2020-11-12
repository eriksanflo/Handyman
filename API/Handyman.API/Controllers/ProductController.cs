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

        [HttpPut]
        [Route("ItemQuotation")]
        public async Task<IActionResult> SaveItemQuotation(ItemQuotationCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        [HttpPut]
        [Route("UnitQuotation")]
        public async Task<IActionResult> SaveUnitQuotation(UnitQuotationCommand cmd)
        {
            var result = await Mediator.Send(cmd);
            if (result.Success)
                return Ok();
            else
                return BadRequest(result.HttpResponse);
        }

        // DELETE Disable a Product
        /*
         Tipo; HttpDel
         Route; Item/{idItem}
         Nombre funcion: DeleteItem(int idItem)
         Busca el item especificado y lo marca como inactivo
         */
        [HttpDelete]
        [Route("Item/{idItem}")]
        public async Task<IActionResult> DeleteItem(int idItem)
        {
            return Ok();
        }

        // GET GetProducts {IdCategory}
        /*
         Tipo; HttpGet
         Route; Category/{idCategory}/Item
         Nombre funcion: GetItemsByTipe(int idCategory)
         Regresa todos los items del Tipo especificad en formato json
         */
        [HttpGet]
        [Route("Category/{idCategory}/Item")]
        public async Task<IActionResult> GetItemsByTipe(int idCategory)
        {
            return Ok();
        }

        // GET GetProduct {IdProduct}
        /*
         Tipo; HttpGet
         Route; Item/{idProduct}
         Nombre funcion: GetItem(int idProduct)
         Regresa el items en formato json
         */
        [HttpGet]
        [Route("Item/{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            return Ok();
        }
    }
}
