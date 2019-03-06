using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuyguOdev.Models;
using Microsoft.AspNetCore.Mvc;

namespace DuyguOdev.Controllers
{
    public class StudentsController : Controller
    {
        StudentsContext StudentContext;

        public StudentsController(StudentsContext context)
        {
            StudentContext = context;
        }

     public IActionResult Index()
        {
            var students = StudentContext.Students.ToList();
            return View(students);
        }

        public IActionResult Detay(int id)
        {
            
            Student student = StudentContext.Students.Where(b => b.Id == id).FirstOrDefault();
            if (student != null)
            {
                return View(student);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
