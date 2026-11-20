using Microsoft.AspNetCore.Mvc;
using MVCDemoGo1.Models;

namespace MVCDemoGo1.Controllers
{
    [Route("Prod")]
    public class ProductController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Json")]
        public IActionResult JsonAction()
        {
            return Json("Hello from json action");
        }

        public IActionResult Search(ProductFilter filter)
        {
            return View();
        }

        public IActionResult GetById([FromQuery]int id,[FromQuery(Name = "id2")]int otherId)
        {
            return Json("");
        }

    }
}
