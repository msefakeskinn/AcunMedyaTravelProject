using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            // Sabit test değerleri
            ViewBag.TotalCategories = 5;
            ViewBag.TotalDestinations = 10;
            ViewBag.TotalServices = 8;
            ViewBag.TotalTrips = 12;
            ViewBag.TotalTripExamples = 6;
            ViewBag.TotalTestimonials = 4;
            ViewBag.TotalSliders = 3;
            ViewBag.TotalAdmins = 2;
            ViewBag.TotalSponsors = 7;
            ViewBag.TotalSubscribers = 15;

            ViewBag.DestinationCount = 10;
            ViewBag.ServiceCount = 8;
            ViewBag.TripExampleCount = 6;
            ViewBag.CategoryCount = 5;

            // Boş listeler
            ViewBag.RecentDestinations = new List<object>();
            ViewBag.RecentServices = new List<object>();
            ViewBag.RecentTestimonials = new List<object>();
            ViewBag.PopularCategories = new List<object>();

            return View();
        }
    }
}