using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSITDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CSITDemo.Controllers.API
{
    [Route("api/[controller]")]//attribute route compulsory
    [ApiController]
    public class StudentController : ControllerBase
    {

        public List<StudentModel> Get()
        {
            return GetStudentsModelsFromDb();
        }
        private List<StudentModel> GetStudentsModelsFromDb()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { Name = "student 1", Address = "maitidevi" });
            students.Add(new StudentModel { Name = "student 2", Address = "balaju" });
            students.Add(new StudentModel { Name = "student 3", Address = "biratnagar" });

            return students;
        }


    }
}
