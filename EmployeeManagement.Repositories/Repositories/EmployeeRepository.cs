using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Repositories.Context;
using EmployeeManagement.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositories.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _employeeContext;


        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public void CreateEmployee(Employee employee)
        {
            if (employee != null)
            {
                _employeeContext.Employees.Add(employee);
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
        }

        public async Task<Employee?> GetEmployee(int id)
        {
            return _employeeContext.Employees.Where(x => x.Id==id).FirstOrDefault();
        }

        public async Task<List<Employee?>> GetEmployees()
        {
            return _employeeContext.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            if (employee != null)
            {
                _employeeContext.Employees.Update(employee);
            }
        }
    }
}
