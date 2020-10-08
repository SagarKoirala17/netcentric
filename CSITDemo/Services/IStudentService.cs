using CSITDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSITDemo.Models;

namespace CSITDemo.Services
{
    public interface IStudentService
    {
        List<StudentModel> GetAllStudents();
        StudentModel GetStudentById(int id);
        

    }
}
