using BusinesLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaretUI.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        // GET: AdminCategory
        public ActionResult Index()
        {
            return View(categoryRepository.GetList());
        }
        public ActionResult Create()
        {
            return View();
        }
        //[ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Insert(category);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Bir hata oluştu");
            return View();
        }
        public ActionResult Delete(int id)
        {
            var delete = categoryRepository.GetById(id);
            categoryRepository.Delete(delete);
            return RedirectToAction("Index");
        }
    }
}