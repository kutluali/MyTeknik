using Microsoft.AspNetCore.Mvc;

namespace MyTeknik.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Vision()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
