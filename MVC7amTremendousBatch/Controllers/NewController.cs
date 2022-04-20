using MVC7amTremendousBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7amTremendousBatch.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        //Deepika from London
        public string Welcome()
        {

            return "Hello World";
        }

        public ActionResult Index()
        {
            return View("Index1");//View() method going to help me to return view page
        }
        //url:new/index2==>Aboutus page of Default Controller
        public ActionResult Index2()
        {
            return View("~/Views/Default/AboutUs.cshtml");
        }


        public string GetId(int? sid)
        {
            return "My Employee Id is " + sid;
        }


        public string GetEmployeeDetail(int? id)
        {
            return "My Employee Id is " + id +
                " Employee Name is " + Request.QueryString["Name"]
                + " Designation is " + Request.QueryString["Designation"];
        }

        [Route("Ecomerce/Dashboard")]
        [Route("Bankruptcy/Dashboard")]
        [Route("CMS/Dashboard")]
        [Route("New/WelcomePage")]
        public string WelcomePage()
        {
            return "Welcome to Dashboard Page";
        }

        public ActionResult SendData()
        {
           
            ViewBag.Name = "Naresh";

                //dynamic property which help us to send data from controller to view
            return View();
        }


        public ActionResult SendData2()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Kevin";
            emp.EmpSalary = 567890;

            ViewBag.info = emp;
         
            return View();
        }

        public ActionResult SendData3()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "prashanth";
            emp.EmpSalary = 450000;

          


            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Gauri";
            emp1.EmpSalary = 650000;

          


            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "sadam";
            emp2.EmpSalary = 750000;


            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            ViewBag.info = listEmp;


            return View();
        }

        public ActionResult SendData4()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Kevin";
            emp.EmpSalary = 567890;

            //Object model=emp;
            return View(emp);
        }

        public ActionResult SendData5(int? id)
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "prashanth";
            emp.EmpSalary = 450000;




            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Gauri";
            emp1.EmpSalary = 650000;




            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "sadam";
            emp2.EmpSalary = 750000;


            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

           


            return View(listEmp);
        }

        public ViewResult SendData6()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "prashanth";
            emp.EmpSalary = 450000;
            
            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Gauri";
            emp1.EmpSalary = 650000;
            
            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "sadam";
            emp2.EmpSalary = 750000;


            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1;
            dept1.DeptName = "IT";

            DepartmentModel dept2 = new DepartmentModel();
            dept2.DeptId = 2;
            dept2.DeptName = "HR";


            List<DepartmentModel> listDept = new List<Models.DepartmentModel>();
            listDept.Add(dept1);
            listDept.Add(dept2);

            EmpDept empdept = new EmpDept();
            empdept.emp = listEmp;
            empdept.dept = listDept;




            return View(empdept);
        }


        public RedirectResult SendData7()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult SendData8()
        {
            return Redirect("~/new/SendData5?id=1");
        }

        public RedirectToRouteResult SendData9()
        {
            return RedirectToAction("AboutUs", "Default",new {id=1});
        }

        public RedirectToRouteResult SendData10()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "prashanth";
            emp.EmpSalary = 450000;

            return RedirectToAction("GetEmployee", "Default", emp);
        }

        public RedirectToRouteResult SendData11()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "prashanth";
            emp.EmpSalary = 450000;




            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Gauri";
            emp1.EmpSalary = 650000;




            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "sadam";
            emp2.EmpSalary = 750000;


            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return RedirectToAction("GetEmployee2", "Default", listEmp);
        }


        public ViewResult getPartialData()
        {
            return View();
        }
        public ViewResult getPartialData2()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "prashanth";
            emp.EmpSalary = 450000;




            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Gauri";
            emp1.EmpSalary = 650000;




            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "sadam";
            emp2.EmpSalary = 750000;


            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            return View(listEmp);
        }


        public PartialViewResult getPartialData3()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "prashanth";
            emp.EmpSalary = 450000;




            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Gauri";
            emp1.EmpSalary = 650000;




            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "sadam";
            emp2.EmpSalary = 750000;


            List<EmployeeModel> listEmp = new List<EmployeeModel>();
            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            return PartialView("_myEmpPartialView", listEmp);
        }

        //hi shravani
    }
}