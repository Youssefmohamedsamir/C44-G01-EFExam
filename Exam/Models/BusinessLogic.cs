using Exam.BaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    internal class BusinessLogic
    {
        private readonly Context _context;

        public BusinessLogic(Context context)
        {
            _context = context;
        }

        public object MemberStatus { get; private set; }

        public void BorrowBook(int memberId, int bookId)
        {
            var Member = _context.Members.Find(memberId);
            var Book = _context.Books.Find(bookId);

            if (Book == null || Book.AvailableCopies <= 0)
            {
                Console.WriteLine("Book Not Found");
            }

            else
            {
                Book.AvailableCopies -= 1;
                var loan = new Loan
                {
                    BookId = bookId,
                    MemberId = memberId,
                    LoanDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(14),
                    ReturnDate = null
                };
                _context.Loans.Add(loan);
                _context.SaveChanges();
                Console.WriteLine("Book Borrowed Successfully");

            }

        }


        public void ReturnBook(int loanId)
        {
            var loan = _context.Loans.Find(loanId);
            if (loan == null || loan.ReturnDate != null)
            {
                Console.WriteLine("Invalid Loan Record");
                return;
            }
            var book = _context.Books.Find(loan.BookId);
            if (book != null)
            {
                book.AvailableCopies += 1;
            }


            loan.ReturnDate = DateTime.Now;
            if (loan.ReturnDate > loan.DueDate)
            {
                var daysLate = (loan.ReturnDate.Value - loan.DueDate).Days;
                var fineAmount = daysLate * 1; 
                var fine = new Fine
                {
                    LoanId = loan.Id,
                    Amount = fineAmount,
                };

                _context.Fines.Add(fine);

                Console.WriteLine($"Book returned late. Fine incurred: ${fineAmount}");
            }
            else
            {
                Console.WriteLine("Book returned on time. No fine incurred.");
            }
            _context.SaveChanges();
        }
    }
}
