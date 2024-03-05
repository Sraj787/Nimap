using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            //LINQ Syntax
            var query =
                from c in context.Courses
                where c.Name.Contains("c#")
                orderby c.Name
                select c;
            foreach (var c in query)
            {
                Console.WriteLine(c.Name);
            }

            //Extension methods
            var courses = context.Courses
                .Where(c => c.Name.Contains("C#"))
                .OrderBy(c => c.Name);

            foreach(var c  in courses)
            {
                Console.WriteLine(c.Name);
            }

        }
    }
}
