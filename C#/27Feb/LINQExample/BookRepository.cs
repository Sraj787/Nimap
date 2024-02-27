namespace LINQExample
{
    internal partial class Program
    {
        public class BookRepository
        {
            public IEnumerable<Book> Getbooks()
            {
                return new List<Book>
                {
                    new Book(){Title = "ASP.net step by step",Price = 5},
                    new Book(){Title = "ASP.net MVC",Price = 9.99f},
                    new Book(){Title = "ASP.net web",Price = 12.6f},
                    new Book(){Title = "C# Basic",Price = 12}

            };
            }
        }
    }
}
