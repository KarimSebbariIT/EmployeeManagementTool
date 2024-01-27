using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.BLL.UserServices;
using ToolManagementAspNetCoreService.DAL.Repositories.UserRepository;
using ToolManagementAspNetCoreService.Domain.DBContext;

namespace ToolManagementAspNetCoreService.BLL.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        => this._userRepository = userRepository;

        public async Task<bool> Create(User cours)
        {
            return await _userRepository.Create(cours);
        }

        public async Task<bool> Delete(int id)
        {
            return await _userRepository.Delete(id);
        }

        public async Task<bool> Edit(User cours)
        {
            return await _userRepository.Edit(cours);
        }

        public async Task<User> GetByID(int id)
        {
            return await _userRepository.GetByID(id);
        }

        public async Task<User> Login(string login, string password)
        {
            return await _userRepository.Login(login, password);
        }

        public async Task<IEnumerable<User>> Users()
        {
            return await _userRepository.Users();
        }
    }
}
