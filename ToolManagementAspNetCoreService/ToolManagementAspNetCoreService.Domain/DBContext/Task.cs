using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolManagementAspNetCoreService.Domain.DBContext
{
    [Table("Task")]
    public class TaskUser
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public int? AssignedTo { get; set; }
        public string? TaskType { get; set; }
        public DateTime? DateOfAssignement { get; set; }
        public DateTime? LimitedDate { get; set; }
        public bool isDone { get; set; }
    }
}
