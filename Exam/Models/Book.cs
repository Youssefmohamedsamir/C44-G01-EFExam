using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class Book: BaseEntity
    {
        
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public int PublicationYear { get; set; }
        public int AvailableCopies { get; set; }
        public int TotalCopies { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }= null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<Loan> Loans { get; set; }= new HashSet<Loan>();




    }
}
