using EmployeeManagement.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repositories.unitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeContext _employeeContext;
        public UnitOfWork(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public  void Clear()
        {
            _employeeContext.ChangeTracker.Clear();
        }

        public async Task SaveChangesAsync()
        {
            await _employeeContext.SaveChangesAsync();
        }
    }
}
