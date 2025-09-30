using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class Category: BaseEntity
    {
        
        public string? Title { get; set; }
        public string? Description { get; set; }

        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
