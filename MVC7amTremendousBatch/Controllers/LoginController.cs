using MVC7amTremendousBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC7amTremendousBatch.Models;
using System.Web.Security;

namespace MVC7amTremendousBatch.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            CountryEntities db = new CountryEntities();

            var userDetails = db.UserDetails.Where(u => u.UserName == user.UserName && u.Password == user.Password).SingleOrDefault();

            if (userDetails!=null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Dashboard");
            }

            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/login/login");
        }

        


        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult ContactUs()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]

        public ActionResult AboutUs()
        {
            return View();
        }
        [OutputCache(Duration =20,Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult CacheExample()
        {
            return View();
        }

    
    }
}