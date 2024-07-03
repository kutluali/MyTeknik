using Microsoft.AspNetCore.Mvc;

namespace MyTeknik.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
