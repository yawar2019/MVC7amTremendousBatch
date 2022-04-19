using MVC7amTremendousBatch.Models;
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
        public ActionResult AboutUs(int? id )
        {
            return View();
        }

        public ActionResult GetEmployee(EmployeeModel emp)
        {
            return View();

        }

        public ActionResult GetEmployee2(List<EmployeeModel> emp)
        {
            return View();

        }
    }
}