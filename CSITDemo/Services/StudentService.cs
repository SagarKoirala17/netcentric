using CSITDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSITDemo.Services
{
    public class StudentService : IStudentService
    {
        public List<StudentModel> GetAllStudents()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { id = 1, Name = "student 1", Address = "maitidevi" });
            students.Add(new StudentModel { id = 2, Name = "student 2", Address = "balaju" });
            students.Add(new StudentModel { id = 3, Name = "student 3", Address = "biratnagar" });

            return students;
        }
        public StudentModel GetStudentById(int id)
        {
            var student = GetAllStudents().FirstOrDefault(x => x.id == id);
            return student;
        }
    }
}