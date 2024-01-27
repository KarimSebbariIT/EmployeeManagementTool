using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Models.Student;
using StudentManagement.Services.IServices;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;   
        }

        [HttpPost("CreateStudent")]
        public async Task<ActionResult<StudentResponseModel>> CreateStudent(Student student)
        {
            return await _studentService.CreateStudent(student);
        }
        [HttpPut("EditStudent")]
        public async Task<ActionResult<StudentResponseModel>> EditStudent(Student student)
        {
            return await _studentService.CreateStudent(student);
        }
    }
}
