using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFMVCDemo.EFConnect;
using System.Data.Entity;

using EFMVCDemo.Models;
using EFMVCDemo.Repository;

namespace EFMVCDemo.Data.Repository
{
    //We have to create this class to feed the data into table as the starting of the application.
    public class DBContextSeederRepository : DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            DepartmentViewModel department1 = new DepartmentViewModel()
            {
                DepartmentName = "IT",
                Employee = new List<EmployeeViewModel>()
                {
                    new EmployeeViewModel()
                    {
                        FirstName = "Vang",
                        LastName = "P",
                        JobTitle = "Software Engineer",
                        Address = "Tampa",
                    },
                    new EmployeeViewModel()
                    {
                        FirstName = "Joseph",
                        LastName = "Yng",
                        JobTitle = "Web Developer",
                        Address = "Tampa",
                    }
                }
            };

            DepartmentViewModel department2 = new DepartmentViewModel()
            {
                DepartmentName = "HR",
                Employee = new List<EmployeeViewModel>()
                {
                    new EmployeeViewModel()
                    {
                        FirstName = "Sarah",
                        LastName = "Mcintosh",
                        JobTitle = "HR Manager",
                        Address = "Orlando",
                    }
                }
            };

            context.Departments.Add(department1);
            context.Departments.Add(department2);

            base.Seed(context);
        }
    }
}