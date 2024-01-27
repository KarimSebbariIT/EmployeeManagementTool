using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ToolManagementAspNetCoreService.Domain.DBContext;

namespace ToolManagementAspNetCoreService.DAL.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Users();
        Task<bool> Create(User cours);
        Task<bool> Edit(User cours);
        Task<bool> Delete(int id);
        Task<User> GetByID(int id);
        Task<User> Login(string login,string password);
    }
}
