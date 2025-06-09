using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class DefaultController : Controller
    {

        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialSliders() 
        {
            var sliders = _context.Sliders.ToList();
            return PartialView(sliders);
        }

        public PartialViewResult PartialServices()
        {
            var services = _context.Services.ToList();
            return PartialView(services);
        }
        
        public PartialViewResult PartialDestinations()
        {
            var destinations = _context.Destinations.ToList();
            return PartialView(destinations);
        }

        public PartialViewResult PartiaTrips()
        {
            var trips = _context.Trips.ToList();
            return PartialView(trips);
        }

        public PartialViewResult PartialTripExamples()
        {
            var tripExamples = _context.TripExamples.ToList();
            return PartialView(tripExamples);
        }

        public PartialViewResult PartialTestimonials()
        {
            var testimonials = _context.Testimonials.ToList();
            return PartialView(testimonials);
        }

        public PartialViewResult PartialSponsors()
        {
            var sponsors = _context.Sponsor.ToList();
            return PartialView(sponsors);
        }

        public PartialViewResult PartialContainer()
        {
            return PartialView();
        }


        [HttpPost]
        public JsonResult PartialSubscribers(Subscriber model)
        {
            
            if (ModelState.IsValid)
            {
                _context.Subscribers.Add(model);
                _context.SaveChanges();
                return Json(new { success = true, message = "Tebrikler Abone oldunuz" });
            }
            else
            {
                return Json(new { success = false, message = "Hata abone olamadınız" });

            }


        }
    }
}