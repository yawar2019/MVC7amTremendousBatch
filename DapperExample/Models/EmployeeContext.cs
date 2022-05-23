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

        public int SaveData(EmployeeModel emp)
        {
            var param = new DynamicParameters();
            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);

            int result = con.Execute("sp_InsertEmployee", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

        public EmployeeModel getDataById(int? id)
        {
            var param = new DynamicParameters();
            param.Add("@empid", id);
            EmployeeModel result = con.QuerySingle<EmployeeModel>("spr_getEmployeeDetailsbyId", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

        public int UpdateData(EmployeeModel emp)
        {
            var param = new DynamicParameters();
            param.Add("@Empid", emp.EmpId);
            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);
            int result = con.Execute("spr_updateEmployeeDetails", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

        public int DeleteData(int? id)
        {
            var param = new DynamicParameters();
            param.Add("@empid", id);
            int result = con.Execute("spr_deleteEmployeeDetails", param: param, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}

