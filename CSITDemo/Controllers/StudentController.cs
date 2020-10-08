using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CSITDemo.Controllers.API;
using CSITDemo.Models;
using CSITDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace CSITDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Index()
        {
            var model = _service.GetAllStudents();
            return View(model);

        }
        public IActionResult GetSingleStudent(int id)
        {
            var model = _service.GetStudentById(id);
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
