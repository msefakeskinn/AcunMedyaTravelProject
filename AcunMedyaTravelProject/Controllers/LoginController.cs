using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AcunMedyaTravelProject.Entities;
namespace AcunMedyaTravelProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }



        [HttpPost]
        public ActionResult Index(Admin model)
        {
            var values = _context.Admins.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);

            // == eşittir 
            // != eşit değildir 

            // 10 != 20




            if (values == null)
            {
               
                ModelState.AddModelError(string.Empty,"Kullancı adı veya şifre hatalı" );
                return View(model);
            }
            FormsAuthentication.SetAuthCookie(model.UserName, false);

            Session["CurrentUser"] = model.UserName;

            return RedirectToAction("Index","Services");

            
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}