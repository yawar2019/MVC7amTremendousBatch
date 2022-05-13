using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        public ActionResult EmployeeDept()
        {
            var EmpDetails =(from emp in db.EmployeeModels 
                             join 
                             dept in db.DepartmentModels
                             on emp.DeptId equals dept.DeptId
                             select new EmpDept
                             {
                                 EmpName=emp.EmpName,
                                 EmpSalary=emp.EmpSalary,
                                 DeptName=dept.DeptName
                             }
                             ).ToList();
            return View(EmpDetails);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.EmployeeModels.Add(emp);
            int result=db.SaveChanges();
            if (result > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            db.Entry(emp).State =  EntityState.Modified;

            int result = db.SaveChanges();
            if (result > 0)
            {
                return RedirectToAction("Index");
            }


            return View();
        }

        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            db.EmployeeModels.Remove(emp);
            int result = db.SaveChanges();
            if (result > 0)
            {
                return RedirectToAction("Index");
            }


            return View();
        }
    }
}