using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EFMVCDemo.Models;

namespace EFMVCDemo.EFConnect
{
    public class EmployeeDBContext: DbContext
    {
        public DbSet<DepartmentViewModel> Departments { get; set; } 
        public DbSet<EmployeeViewModel> Employees { get; set; }
    }
}