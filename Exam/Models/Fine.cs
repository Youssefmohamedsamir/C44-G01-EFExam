using Exam.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class Fine
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public StatusFine Status { get; set; } 

        public int LoanId { get; set; }
        public Loan Loan { get; set; }
    }
}
