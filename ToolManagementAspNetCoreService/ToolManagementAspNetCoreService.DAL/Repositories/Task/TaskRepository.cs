using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.DAL.UnitOfWork;
using ToolManagementAspNetCoreService.Domain.DBContext;

namespace ToolManagementAspNetCoreService.DAL.Repositories.Task
{
    internal class TaskRepository: ITaskRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public TaskRepository(IUnitOfWork unitOfWOrk)
            => this._unitOfWork = unitOfWOrk;

        public async Task<bool> Create(TaskUser task)
        {
            return await _unitOfWork.Task.Add(task);
        }

        public async Task<bool> Delete(int id)
        {
            return await _unitOfWork.User.Delete(id);
        }

        public async Task<bool> Edit(TaskUser task)
        {
            return await _unitOfWork.Task.Edit(task);
        }

        public async Task<TaskUser> GetByID(int id)
        {
            return await _unitOfWork.Task.Get(x => x.ID == id);
        }

        public async Task<IEnumerable<TaskUser>> Tasks()
        {
            return await _unitOfWork.Task.All();
        }
    }
}
