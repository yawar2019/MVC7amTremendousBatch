using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HandleError(View ="Error1")]
        public ActionResult GetData()
        {
            try
            {
                int a = 10, b = 0;
                int c = a/b;
                return View();
            }
            catch (Exception ex)
            {
                return View("Error1",new HandleErrorInfo(ex,"home","GetData"));
                 
            }
            
        }
    }
}