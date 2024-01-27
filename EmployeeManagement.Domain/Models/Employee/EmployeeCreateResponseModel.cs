using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Models.Employee
{
    internal class EmployeeCreateResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
