using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.DAL.UnitOfWork;
using ToolManagementAspNetCoreService.Domain.DBContext;

namespace ToolManagementAspNetCoreService.DAL.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRepository(IUnitOfWork unitOfWOrk)
            => this._unitOfWork = unitOfWOrk;

        public async Task<bool> Create(User cours)
        {
            return await _unitOfWork.User.Add(cours);
        }

        public async Task<bool> Delete(int id)
        {
            return await _unitOfWork.User.Delete(id);
        }

        public async Task<bool> Edit(User cours)
        {
            return await _unitOfWork.User.Edit(cours);
        }

        public async Task<User> GetByID(int id)
        {
            return await _unitOfWork.User.Get(x => x.ID == id);
        }

        public async Task<User> Login(string login, string password)
        {
            return await _unitOfWork.User.Get(x => x.Login == login.Trim() & x.Password == password.Trim());
        }

        public async Task<IEnumerable<User>> Users()
        {
            return await _unitOfWork.User.All();
        }
    }
}
