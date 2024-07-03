using Microsoft.AspNetCore.Mvc;
using MyTeknik.Core.Service;
using MyTeknik.Model.Entities;

namespace MyTeknik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IDbService<Category> _db;

        public CategoryController(IDbService<Category> db)
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
        public IActionResult Add(Category c)
        {
            if (c.CategoryName != null)
            {
                return _db.Add(c) ? RedirectToAction("Index") : View();
            }

            ViewBag.CategoryAddError = "Kategori Adını Giriniz";
            return View();
        }

        public IActionResult Update(int id)
        {
            return View(_db.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Category c)
        {
            if (c.CategoryName != null)
            {
                return _db.Update(c) ? RedirectToAction("Index") : View();
            }

            ViewBag.CategoryUpdateError = "Güncellemek için değerleri Giriniz";
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
