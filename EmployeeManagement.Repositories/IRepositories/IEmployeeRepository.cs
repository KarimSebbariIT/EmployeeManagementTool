using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositories.IRepositories
{
    public interface IEmployeeRepository
    {
        void CreateEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);


    }
}
