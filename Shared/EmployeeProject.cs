using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Shared
{
    public class EmployeeProject
    {
        [Key]
        public Guid EmployeeProjectId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
