using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize] 
    public class TestimonialController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTestimonial(Testimonials model)
        {

            _context.Testimonials.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonials model)
        {
            var value = _context.Testimonials.Find(model.TestimonialID);
            value.Title = model.Title;
            value.Description = model.Description;
            value.ImageURL = model.ImageURL;
            value.TestimonialName = model.TestimonialName;
            value.Degree = model.Degree;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}