using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class CategoriesController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();

        public ActionResult Index()
        {
            var values = _context.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddCategories()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategories(Category model)
        {

            _context.Categories.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategories(int id)
        {
            var value = _context.Categories.Find(id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategories(int id)
        {
            var value = _context.Categories.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategories(Category model)
        {
            var value = _context.Categories.Find(model.CategoryID);
           value.Name = model.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}