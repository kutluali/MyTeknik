using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTeknik.Core.Service;
using MyTeknik.Model.Entities;

namespace MyTeknik.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IDbService<Product> _db;
        private readonly IDbService<Category> _dbCategory;
        private readonly IDbService<Brand> _dbBrand;

        public ProductController(IDbService<Product> db, IDbService<Category> dbCategory, IDbService<Brand> dbBrand)
        {
            _db = db;
            _dbCategory = dbCategory;
            _dbBrand = dbBrand;
        }

        public IActionResult Index()
        {
            return View(_db.GetAll());
        }

        public IActionResult Add()
        {
            ViewBag.CategoryList = _dbCategory.GetAll();
            ViewBag.BrandList = _dbBrand.GetAll();
            return View();

        }

        [HttpPost]
        public IActionResult Add(Product p, IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var filename = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "images", "product", filename);


                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    p.ProductImage = filename;
                    return _db.Add(p) ? RedirectToAction("Index") : View();

            }

            ViewBag.CategoryList = _dbCategory.GetAll();
            ViewBag.BrandList = _dbBrand.GetAll();
            return View(p);
        }

        //public IActionResult Update()
        //{
        //    return View(_db.GetAll());
        //}
        //[HttpPost]
        //public IActionResult Update(Product p)
        //{
        //    return View(_db.GetAll());
        //}

        //public IActionResult Delete()
        //{
        //    return View(_db.GetAll());
        //}
    }
}
