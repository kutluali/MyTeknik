using Microsoft.AspNetCore.Mvc;
using MyTeknik.Core.Service;
using MyTeknik.Model.Entities;

namespace MyTeknik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly IDbService<Brand> _db;

        public BrandController(IDbService<Brand> db)
        {
           _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.GetAll());
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Brand b)
        {
            if (b.BrandName != null)
            {
                return _db.Add(b) ? RedirectToAction("Index") : View();
            }

            ViewBag.BrandAddError = "Marka Adını Giriniz";
            return View();
        }

        public IActionResult Update(int id)
        {
            return View(_db.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Brand b)
        {
            if (b.BrandName != null)
            {
                return _db.Update(b) ? RedirectToAction("Index") : View();
            }

            ViewBag.BrandUpdateError = "Güncellemek için değerleri Giriniz";
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                return _db.Delete(_db.GetById(id)) ? RedirectToAction("Index") : View();
            }
            return View();

        }
    }
}
