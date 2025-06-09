using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize] 
    public class TripsController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Trips.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddTrips()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTrips(Trip model)
        {

            _context.Trips.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTrips(int id)
        {
            var value = _context.Trips.Find(id);
            _context.Trips.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTrips(int id)
        {
            var value = _context.Trips.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTrips(Trip model)
        {
            var value = _context.Trips.Find(model.TripID);
            value.Title = model.Title;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.IconURL = model.IconURL;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}