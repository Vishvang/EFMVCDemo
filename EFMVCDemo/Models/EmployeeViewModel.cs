using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

//To handle changes into model we need to add
//SetInitializer method in to Global.asax.cs

namespace EFMVCDemo.Models
{
    [Table("Employee")]
    public class EmployeeViewModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //After creating table we have field Department_DepartmentId
        //So create this property and pass this property to ForeignKey Property 
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public DepartmentViewModel Department { get; set; }

        public string JobTitle { get; set; }
        public string Address { get; set; }
    }
}