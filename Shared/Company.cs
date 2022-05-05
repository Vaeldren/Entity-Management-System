using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Shared
{
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Ceo { get; set; }
        public int EmployeeCount { get; set; }
    }
}
