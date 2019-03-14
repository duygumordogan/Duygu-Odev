using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DuyguOdev.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [Display(Name = "Student Number")]
        public long StuID { get; set; }
        [Display(Name = "Department Name")]
        public int DepartmentId { get; set; }
       
        public Department Department { get; set; }

        
    }
}