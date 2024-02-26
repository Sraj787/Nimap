namespace whileLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int i = 1;
            while (i <= 10)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/

           while(true)
            {
                Console.WriteLine("Type Your Name:");
                var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                   // break;
                
            }
        }
    }
}
