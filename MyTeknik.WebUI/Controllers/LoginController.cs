using Microsoft.AspNetCore.Mvc;
using MyTeknik.Core.Service;
using MyTeknik.Model.Entities;

namespace MyTeknik.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IDbService<Admin> _db;
        public LoginController(IDbService<Admin> db)
        {
           _db = db;
        }

        public IActionResult LoginOut()
        {
            return View();
        }
    }
}
