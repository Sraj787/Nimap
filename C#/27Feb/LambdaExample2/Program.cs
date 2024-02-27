using System.Reflection;

namespace LambdaExample2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var books = new BooksRepository().GetBooks();

            var chepBooks = books.FindAll(b => b.Price < 10);
            
            foreach (var book in chepBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
        /*static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }*/
    }
}
