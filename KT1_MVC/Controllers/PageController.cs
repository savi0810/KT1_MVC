using Microsoft.AspNetCore.Mvc;

namespace KT1_MVC.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        [Route("Page/Greet/{name=Alex}")]
        public IActionResult Greet(string name)
        {
            ViewData["name"] = name;
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(string message)
        {
            ViewData["message"] = message;
            return View("EditRes");
        }

    }
}
