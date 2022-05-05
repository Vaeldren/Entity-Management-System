using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Shared
{
    public class Ticket
    {
        [Key]
        public Guid TicketId { get; set; }

        [Required]
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public Employee AssignedUser { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
