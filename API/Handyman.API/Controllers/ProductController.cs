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
        /*
         Tipo; HttpGet
         Route; Category
         Nombre funcion: GetTypes()
         Retornara totas las categorias en formato json, un string
         */

        // GET GetCategory {IdCategory}
        /*
         Tipo; HttpGet
         Route; Category/{idCategory}
         Nombre funcion: GetType(int idCategory)
         Retornara una categoria en formato json, un string
         */

        // PUT Create/Update a Product
        /*
         Tipo; HttpPut
         Route; Category/{idCategory}/Item
         Nombre funcion: SaveItem(int idCategory, ItemCommand cmd)
         Registrara un item del tipo especificado, con la información del comando enviado
         */

        // DELETE Disable a Product
        /*
         Tipo; HttpDel
         Route; Item/{idItem}
         Nombre funcion: DeleteItem(int idItem)
         Busca el item especificado y lo marca como inactivo
         */

        // GET GetProducts {IdCategory}
        /*
         Tipo; HttpGet
         Route; Category/{idCategory}/Item
         Nombre funcion: GetItemsByTipe(int idCategory)
         Regresa todos los items del Tipo especificad en formato json
         */

        // GET GetProduct {IdProduct}
        /*
         Tipo; HttpGet
         Route; Item/{idProduct}
         Nombre funcion: GetItem(int idProduct)
         Regresa el items en formato json
         */
    }
}
