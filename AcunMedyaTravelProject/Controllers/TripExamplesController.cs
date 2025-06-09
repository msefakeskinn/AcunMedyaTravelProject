using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class TripExamplesController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values =_context.TripExamples.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTripExamples()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTripExamples(TripExample model)
        {

            _context.TripExamples.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTripExamples(int id)
        {
            var value = _context.TripExamples.Find(id);
            _context.TripExamples.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTripExamples(int id)
        {
            var value = _context.TripExamples.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTripExamples(TripExample model)
        {
            var value = _context.TripExamples.Find(model.TripExampleID);
            value.Title = model.Title;
            value.Description1 = model.Description1;
            value.IconURL = model.IconURL;
            value.ImageURL = model.ImageURL;
            value.Description2 = model.Description2;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}