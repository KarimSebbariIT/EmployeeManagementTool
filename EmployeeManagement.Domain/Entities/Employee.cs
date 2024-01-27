using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Entities
{
    public class Employee
    {

        //test
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string City { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
    }
}
