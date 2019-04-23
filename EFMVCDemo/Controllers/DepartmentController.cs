using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFMVCDemo.Repository;
using EFMVCDemo.Models;

namespace EFMVCDemo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult DepartmentList()
        {
            DepartmentRepository departmentRepo = new DepartmentRepository();
            List<DepartmentViewModel> departmetns = departmentRepo.GetDepartmentList();
            return View(departmetns);
        }
    }
}