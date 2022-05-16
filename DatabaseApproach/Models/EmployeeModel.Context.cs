﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseApproach.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmployeeDbEntities1 : DbContext
    {
        public EmployeeDbEntities1()
            : base("name=EmployeeDbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Employee> tbl_Employee { get; set; }
    
        public virtual int spr_insertEmpDetails(string empName, Nullable<int> empSalary)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var empSalaryParameter = empSalary.HasValue ?
                new ObjectParameter("EmpSalary", empSalary) :
                new ObjectParameter("EmpSalary", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spr_insertEmpDetails", empNameParameter, empSalaryParameter);
        }
    
        public virtual ObjectResult<usp_employee_Result> usp_employee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_employee_Result>("usp_employee");
        }
    }
}
