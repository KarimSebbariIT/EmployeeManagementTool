using StudentManagement.Domain.Entities;
using StudentManagement.Repositories.Context;
using StudentManagement.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Repositories.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentManagementContext _context;
        public StudentRepository(StudentManagementContext context)
        {
            _context = context;
        }
        public void CreateStudent(Student student)
        {
            _context.Students.Add(student);

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
