using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.Domain.DBContext;

namespace ToolManagementAspNetCoreService.Domain
{
    public class TaskManagementDBContext : DbContext
    {
        public TaskManagementDBContext(DbContextOptions<TaskManagementDBContext> options)
       : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //User
            modelBuilder.Entity<User>()
                   .Property(x => x.ID)
                   .IsRequired();
            modelBuilder.Entity<User>()
                   .Property(x => x.Level)
                   .IsRequired();
            modelBuilder.Entity<User>()
                   .Property(x => x.FirstName)
                   .IsRequired();
            modelBuilder.Entity<User>()
                   .Property(x => x.LastName)
                   .IsRequired();
            modelBuilder.Entity<User>()
                   .Property(x => x.Login)
                   .IsRequired();
            modelBuilder.Entity<User>()
                   .Property(x => x.Password)
                   .IsRequired();

            //User
            modelBuilder.Entity<TaskUser>()
                   .Property(x => x.ID)
                   .IsRequired();
            modelBuilder.Entity<TaskUser>()
                   .Property(x => x.Title)
                   .IsRequired();
            modelBuilder.Entity<TaskUser>()
                   .Property(x => x.AssignedTo)
                   .IsRequired();
            modelBuilder.Entity<TaskUser>()
                   .Property(x => x.TaskType)
                   .IsRequired();
            modelBuilder.Entity<TaskUser>()
                   .Property(x => x.DateOfAssignement)
                   .IsRequired();
            modelBuilder.Entity<TaskUser>()
                   .Property(x => x.LimitedDate)
                   .IsRequired();
        }

        //entities
        public DbSet<User> User { get; set; }
        public DbSet<TaskUser> Task { get; set; }
    }
}
