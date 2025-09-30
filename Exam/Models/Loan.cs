using Exam.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class Loan: BaseEntity
    {
       
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public StatusLoan Status { get; set; } 

        public int MemberId { get; set; }
        public Member? Member { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }

        public Fine? Fine { get; set; }
    }
}
