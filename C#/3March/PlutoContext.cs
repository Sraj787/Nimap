using System.Data.Entity;

namespace Pluto2
{
    internal partial class Program
    {
        public class PlutoContext : DbContext
        {
            public DbSet<Course> Courses { get; set; }

            public DbSet<Author> Author { get; set; }

            public DbSet<Tag> Tags { get; set; }

           // public DbSet<Category> Categories { get; set; }
        }
    }
}
