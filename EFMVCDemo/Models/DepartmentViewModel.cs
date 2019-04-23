using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFMVCDemo.Models
{
    [Table("Department")]
    public class DepartmentViewModel
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<EmployeeViewModel> Employee { get; set; }
    }
}