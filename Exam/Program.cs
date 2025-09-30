using Exam.BaseContext;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Context context = new Context();

            var businessLogic = new Models.BusinessLogic(context);

            businessLogic.BorrowBook(1, 1);

            //مكسل ادخل داتا علشان مش قادر

            businessLogic.ReturnBook(1);


            //فكلو هيطلع ب Not Found

        }
    }
}
