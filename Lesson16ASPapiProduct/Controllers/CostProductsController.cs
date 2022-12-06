using Lesson16ASPapiProduct.Models.Domain;
using Lesson16ASPapiProduct.Serivces;
using Microsoft.AspNetCore.Mvc;

namespace Lesson_16.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CostProductsController : Controller
    {
        IActionWithProductService action;
        public CostProductsController(IActionWithProductService action)
        {
            this.action = action;
        }

        [HttpGet]
        public IActionResult SummAllProduct()
        {
            return Ok(action.SummAllProducts());
        }

        [HttpGet]
        public IActionResult SummProductType(TypeProducts type)
        {
            return Ok(action.SummProductsOnType(type));
        }
    }
}
