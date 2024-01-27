using EmployeeManagement.Domain.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services.IServices
{
    public interface IEmployeeService
    {
        Task<EmployeeCreateResponseModel> CreateEmployee(EmployeeCreateModel employee);
        Task<EmployeeUpdateResponseModel> UpdateEmployee(EmployeeUpdateModel employee);
        Task<EmployeeDeleteResponseModel> DeleteEmployee(EmployeeModel employee);
        Task<List<EmployeeModel>> GetEmployees();
        Task<EmployeeModel> GetEmployee(int id);
    }
}
