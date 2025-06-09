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
    public class DestinationsController : Controller
    {
        //tüm projede arama = ctrl shift f
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
           var values = _context.Destinations.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddDestinations()
        {
            List<SelectListItem> categories = (from i in _context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = i.Name,
                                                   Value = i.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
            return View();
        }
        [HttpPost]
        public ActionResult AddDestinations(Destinations model)
        {
            List<SelectListItem> categories = (from i in _context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = i.Name,
                                                   Value = i.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;

            if (ModelState.IsValid)
            {
                _context.Destinations.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // If the model state is not valid, return the view with the current model to show validation errors
            return View(model);
        }

        public ActionResult DeleteDestinations(int id)
        {
            var value = _context.Destinations.Find(id);
            _context.Destinations.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateDestinations(int id)
        {
            List<SelectListItem> categories = (from i in _context.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = i.Name,
                                                   Value = i.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
            var value = _context.Destinations.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateDestinations(Destinations model)
        {
            var categoryList = _context.Categories.ToList();
            List<SelectListItem> categories = (from i in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = i.Name,
                                                   Value = i.CategoryID.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
            var value = _context.Destinations.Find(model.DestinationsID);
            value.Title = model.Title;
            value.Description1 = model.Description1;
            value.Description2 = model.Description2;
            value.ImageURL = model.ImageURL;
            value.CategoryID = model.CategoryID;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}