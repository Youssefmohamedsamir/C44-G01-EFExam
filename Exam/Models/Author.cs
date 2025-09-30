using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class Author: BaseEntity
    {
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Book> Books { get; set; }= new HashSet<Book>();
    }
}
