namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeModels", "DeptId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeModels", "DeptId");
        }
    }
}



//var empDept1 = (from emp in db.emp
//                join dept in db.dept
//               on emp.deptId equals dept.deptId
//                select new EmpDetpt
//                {
//                    EmpId = emp.EmpId,
//                    EmpName = emp.EmpName,
//                    DeptName = dept.DeptName
//                }).ToList();