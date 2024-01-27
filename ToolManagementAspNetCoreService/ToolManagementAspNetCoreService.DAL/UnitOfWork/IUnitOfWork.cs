using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.DAL.GenericRepository;
using ToolManagementAspNetCoreService.Domain.DBContext;

namespace ToolManagementAspNetCoreService.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<User> User { get; }
        IRepository<TaskUser> Task { get; }
        void Save();
    }
}
