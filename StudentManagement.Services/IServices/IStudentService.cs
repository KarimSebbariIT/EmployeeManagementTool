using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services.IServices
{
    public interface IStudentService
    {
        Task<StudentResponseModel> CreateStudent(Student student);
    }
}
