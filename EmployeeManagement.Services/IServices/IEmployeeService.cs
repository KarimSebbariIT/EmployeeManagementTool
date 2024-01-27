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
        void CreateEmployee(EmployeeCreateModel employee);
        void UpdateEmployee(EmployeeUpdateModel employee);
        void DeleteEmployee(EmployeeModel employee);
        Task<List<EmployeeModel>> GetEmployees();
        Task<EmployeeModel> GetEmployee(int id);
    }
}
