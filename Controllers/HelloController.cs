using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace return_json.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Example = "HErerererrE";
            return View("Index");
        }
    }
}