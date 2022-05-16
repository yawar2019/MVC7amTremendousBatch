using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace DapperExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        //public List<EmployeeModel> GetEmployeesData()
        //{
        //    var employees = con.Query<EmployeeModel>("SELECT EmpId,EmpName,EmpSalary FROM[Employee].[dbo].[employeeDetails]");
        //    return employees.ToList();
        //}

        public List<EmployeeModel> GetEmployeesData()
        {
            var employees = con.Query<EmployeeModel>("sp_Employee",commandType:CommandType.StoredProcedure);
            return employees.ToList();
        }
    }
}

//select* employee where empid='+Textbox1.text+'  1=1;