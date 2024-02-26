using System.Text;

namespace StringBuilderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder= new StringBuilder("Hello World");
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine("First Character: "+builder[0]);
        }
    }
}
