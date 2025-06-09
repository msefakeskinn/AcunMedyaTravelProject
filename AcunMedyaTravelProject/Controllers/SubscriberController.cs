using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    [Authorize]
    public class SubscriberController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index(string search)
        {
            var values = from x in _context.Subscribers select x;

            if (!string.IsNullOrEmpty(search))
            {
                values = values.Where(x => x.Email.Contains(search));
            }

            return View(values.ToList());
        }

        public ActionResult DeleteSubscriber(int id)
        {
            var value = _context.Subscribers.Find(id);
            _context.Subscribers.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}