using AdoDotnetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoDotnetExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeContext db = new EmployeeContext();

        public ActionResult Index()
        {
           
            return View(db.GetEmployees());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int result = db.SaveEmployee(emp);
            if(result>0)
            {
                return RedirectToAction("index");
            }
            return View(emp);
        }

        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.GetEmployeesById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int result = db.UpdateEmployee(emp);
            if (result > 0)
            {
                return RedirectToAction("index");
            }
            return View(emp);
        }
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.GetEmployeesById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {

            int result = db.DeleteEmployee(id);
            if (result > 0)
            {
                return RedirectToAction("index");
            }
            return View();
        }
    }
}