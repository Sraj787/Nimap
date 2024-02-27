namespace LambdaExample2
{
    internal partial class Program
    {
        public class BooksRepository
        {
            public List<Book> GetBooks()
            {
                return new List<Book>
                {
                    new Book(){Title ="title1",Price = 5 },
                    new Book(){Title ="title2",Price = 7 },
                    new Book(){Title ="title3",Price = 15 }

                };
            }
        }
    }

    public class Book
    {
        public string Title { get; internal set; }
        public int Price { get; internal set; }
    }
}
