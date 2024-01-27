using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.Domain.DBContext;

namespace ToolManagementAspNetCoreService.DAL.Repositories.Task
{
    internal interface ITaskRepository
    {
        Task<IEnumerable<TaskUser>> Tasks();
        Task<bool> Create(TaskUser task);
        Task<bool> Edit(TaskUser task);
        Task<bool> Delete(int id);
        Task<TaskUser> GetByID(int id);
    }
}
