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
    public class SlidersController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Sliders.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSliders()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSliders(Sliders model)
        {

            _context.Sliders.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSliders(int id)
        {
            var value = _context.Sliders.Find(id);
            _context.Sliders.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSliders(int id)
        {
            var value = _context.Sliders.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSliders(Sliders model)
        {
            var value = _context.Sliders.Find(model.SliderID);
            value.Title = model.Title;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.ImageURL = model.ImageURL;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}