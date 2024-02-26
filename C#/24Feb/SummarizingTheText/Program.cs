
namespace SummarizingTheText
{
    internal class Program
    {
       
            static void Main(string[] args)
        {
            var sentance = "This is going to be a really really really long text.....";

           var summary = StringUtility.SummerizeText(sentance);
            Console.WriteLine(summary);
        }

           
        }

    }

