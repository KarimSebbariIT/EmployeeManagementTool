using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Repositories.Context
{
    public class StudentManagementContext: DbContext
    {
        public StudentManagementContext(DbContextOptions<StudentManagementContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
     
        //public DbSet<Student> Students { get; set; }
    }
}
