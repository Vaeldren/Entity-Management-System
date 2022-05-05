using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Shared
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Guid CompanyId { get; set; }
        public Company AssignedCompany { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Completed { get; set; }

    }
}
