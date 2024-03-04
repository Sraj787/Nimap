namespace Pluto2
{
    internal partial class Program
    {
        public class Course
        {
            public int Id { get; set; }
            public string Name {  get; set; }
            public string Description { get; set; }

           // public DateTime? DatePublished { get; set; }
           // public Category Category { get; set; }
            public CourseLevel Level { get; set; }
            public float FullPrice {  get; set; }
            public Author Author { get; set; }

            public IList<Tag> Tags { get; set; }
        }
    }
}
