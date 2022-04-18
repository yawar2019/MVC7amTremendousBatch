using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amTremendousBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}