using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFMVCDemo.Models;
using EFMVCDemo.EFConnect;

namespace EFMVCDemo.Repository
{
    public class DepartmentRepository
    {
        public List<DepartmentViewModel> GetDepartmentList() {

            EmployeeDBContext empDBContext = new EmployeeDBContext();
            List<DepartmentViewModel> department = empDBContext.Departments.ToList();

            return department;
        }
    }
}