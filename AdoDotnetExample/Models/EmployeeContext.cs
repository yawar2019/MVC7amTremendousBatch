using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotnetExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");
        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            SqlCommand cmd = new SqlCommand("sp_employee", con);

            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                emp.EmpName = Convert.ToString(dr["EmpName"]);
                emp.EmpSalary = Convert.ToInt32(dr["EmpSalary"]);
                listEmp.Add(emp);
            }


            return listEmp;
        }

        public int SaveEmployee(EmployeeModel emp)

        {

            SqlCommand cmd = new SqlCommand("sp_CreateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }

        public EmployeeModel GetEmployeesById(int? id)
        {
            SqlCommand cmd = new SqlCommand("sp_getNeerjaEmployeeDetailsById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            EmployeeModel emp = new EmployeeModel();
            foreach (DataRow dr in dt.Rows)
            {
                emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                emp.EmpName = Convert.ToString(dr["EmpName"]);
                emp.EmpSalary = Convert.ToInt32(dr["EmpSalary"]);
            }
            return emp;
        }



        public int UpdateEmployee(EmployeeModel emp)

        {

            SqlCommand cmd = new SqlCommand("sp_UpdateNeerjaEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }

        public int DeleteEmployee(int?id)

        {

            SqlCommand cmd = new SqlCommand("spr_deleteEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@empid", id);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }

        
    }
}