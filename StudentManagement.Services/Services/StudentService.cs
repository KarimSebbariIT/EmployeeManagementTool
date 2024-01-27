using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Models.Student;
using StudentManagement.Repositories.IRepository;
using StudentManagement.Services.IServices;
using StudentManagement.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly UserProfile _mapper;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public async Task<StudentResponseModel> CreateStudent(Student student)
        {
            try
            {
                _studentRepository.CreateStudent(student);
                _studentRepository.SaveChanges();
                return new StudentResponseModel
                {
                    Success = true,
                    Message = "Student successfully created"
                };
            }
            catch (Exception ex)
            {
                return new StudentResponseModel
                {
                    Success = false,
                    Message = ex.Message
                };
            }

        }
    }
}
