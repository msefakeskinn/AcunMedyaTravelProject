using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Head()
        {
            return PartialView();
        }

        public PartialViewResult Navbar()
        {
            return PartialView();
        }

        public PartialViewResult Sidebar()
        {
            return PartialView();
        }
    }
}