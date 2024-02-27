namespace LINQExample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
           var books = new BookRepository().Getbooks();

            var book = books.SingleOrDefault(b=> b.Title == "C# Basic");
            Console.WriteLine(book.Title);

            // LINQ Query Operatos
            /*
                        var cheaperBooks =
                             from b in books
                             where b.Price < 10
                             orderby b.Title
                             select b;
            */

            //LINQ Extension Methods

            /*
                        var cheapBooks = books
                                   .Where(b => b.Price < 10)
                                   .OrderBy(b=>b.Title)
                                   .Select(b=> b.Title);

                        foreach (var book in cheapBooks)
                        {
                            Console.WriteLine(book);
                            // Console.WriteLine(book.Title +" "+book.Price);
                        }
            */

        }
    }
}
