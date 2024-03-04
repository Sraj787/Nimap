namespace Pluto2
{
    internal partial class Program
    {
        public class Author
        {
            public int Id { get; set; }
            public string Name {  get; set; }

            public IList<Course> Courses { get; set; }
        }
    }
}
