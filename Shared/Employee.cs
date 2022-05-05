﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Shared
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string Username { get; set; }
        public Guid CompanyId { get; set; }
        public Company AssignedCompany { get; set; }
    }
}
