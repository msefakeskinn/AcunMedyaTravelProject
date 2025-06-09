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
    public class SponsorsController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values =_context.Sponsor.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSponsors()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSponsors(Sponsor model)
        {

            _context.Sponsor.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSponsors(int id)
        {
            var value = _context.Sponsor.Find(id);
            _context.Sponsor.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSponsors(int id)
        {
            var value = _context.Sponsor.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSponsors(Sponsor model)
        {
            var value = _context.Sponsor.Find(model.SponsorID);
            value.ImageURL = model.ImageURL;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}