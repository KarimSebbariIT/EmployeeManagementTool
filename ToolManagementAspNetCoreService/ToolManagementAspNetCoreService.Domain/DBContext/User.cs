using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolManagementAspNetCoreService.Domain.DBContext
{
    [Table("UserApp")]
    public class User
    {
        public int ID { get; set; }
        public string? Level { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
    }
}
