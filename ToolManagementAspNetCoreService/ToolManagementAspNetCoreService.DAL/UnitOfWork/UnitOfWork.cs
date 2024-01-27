using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.DAL.GenericRepository;
using ToolManagementAspNetCoreService.Domain;
using ToolManagementAspNetCoreService.Domain.DBContext;

namespace ToolManagementAspNetCoreService.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private TaskManagementDBContext _dbContext;
        private Repository<User> _userRepository;
        private Repository<TaskUser> _taskRepository;
        public UnitOfWork(
            TaskManagementDBContext dbContext,
            Repository<User> userRepository, Repository<TaskUser> taskRepository)
        {
            this._userRepository = userRepository;
            this._taskRepository = taskRepository;
            this._dbContext = dbContext;

        }

        public UnitOfWork(TaskManagementDBContext dbContext)
        {
            this._dbContext = dbContext;

        }
        public IRepository<User> User
        {
            get
            {
                return _userRepository ??
                    (_userRepository = new Repository<User>(_dbContext));
            }
        }
        public IRepository<TaskUser> Task
        {
            get
            {
                return _taskRepository ??
                    (_taskRepository = new Repository<TaskUser>(_dbContext));
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChangesAsync();
        }
    }
}
