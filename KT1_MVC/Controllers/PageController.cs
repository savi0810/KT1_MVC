using Microsoft.AspNetCore.Mvc;

namespace KT1_MVC.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Greet(string name)
        {
            ViewData["name"] = name ?? "Alex";
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
