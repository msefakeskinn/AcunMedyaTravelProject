using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaTravelProject.Context;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddServices()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddServices(Services model)
        {

            _context.Services.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteServices(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var value = _context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateServices(Services model)
        {
            var value = _context.Services.Find(model.ServicesID);
            value.Title = model.Title;
            value.Description = model.Description;
            value.ImageURL = model.ImageURL;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

     
    }
}
