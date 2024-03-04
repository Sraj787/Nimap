using System.Data.Entity;

namespace CodeFirstDemo
{
    internal partial class Program
    {
        public class blogDBContext : DbContext { 
        
            public DbSet<Post> Posts { get; set; }
        }
    }
}
