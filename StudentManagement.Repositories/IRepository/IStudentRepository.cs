using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Repositories.IRepository
{
    public interface IStudentRepository
    {
        void CreateStudent(Student student);
        void SaveChanges();
    }
}
