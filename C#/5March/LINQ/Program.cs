using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotations
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

              var tags = context.Courses
                  .Where(c => c.Level == 1)
                  .OrderByDescending(c => c.Name)
                  .ThenByDescending(c => c.Level)
                  .SelectMany(c => c.Tags);

              foreach (var t in tags)
              { 
                      Console.WriteLine(t.Name);
              }

            //Set Operation
              var tags = context.Courses
                .Where(c => c.Level == 1)
                .OrderByDescending(c => c.Name)
                .ThenByDescending(c => c.Level)
                .SelectMany(c => c.Tags)
                .Distinct();

              foreach (var t in tags)
              {
                  Console.WriteLine(t.Name);
              }

            //Grouping
              var groups = context.Courses.GroupBy(c => c.Level);

              foreach (var t in groups)
              {
                  Console.WriteLine("Key: "+ t.Key);
                  foreach(var c in t)
                  {
                      Console.WriteLine("\t" +c.Name);
                  }
              }

            //Joining,
            //Inne Join
              var joins = context.Courses.Join(context.Authors,
                  c => c.AuthorId,
                  a => a.Id,
                  (Course, Author) => new
                      {
                      CourseName = Course.Name,
                      AuthorName = Author.Name
                      });
            //GRoup JOIN
             var join1 = context.Courses.GroupJoin(context.Courses,
                 a=>a.Id,
                 c=>c.AuthorId,
                 (author , course) => new
             {
                 Author = author ,
                 Course = course

             }
             );

            //Cross Join 
            var crossJoin = context.Authors.
                SelectMany(a => context.Courses,
                (authors, course) => new {
                 AuthorName = authors.Name,
                 CourseName = course.Name,
            });


           
        }
    }
}
