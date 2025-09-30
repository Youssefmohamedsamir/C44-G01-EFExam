using Exam.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class Member: BaseEntity
    {
       
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime MembershipDate { get; set; }
        public StatusMember Status { get; set; } 

        public ICollection<Loan> Loans { get; set; }= new HashSet<Loan>();
    }
}
