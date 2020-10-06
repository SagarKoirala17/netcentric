using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSITDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSITDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var model = GetStudentsFromDb();
            return View(model);
        }

        private List<StudentModel> GetStudentsFromDb()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { Name = "student 1", Address = "maitidevi" });
            students.Add(new StudentModel { Name = "student 2", Address = "balaju" });
            students.Add(new StudentModel { Name = "student 3", Address = "biratnagar" });

            return students;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
