namespace Patterns
{
    internal class Program
    {
        public static void Pattern1(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public static void Pattern2(int num)
        {
            for(int i = 1;i <= num; i++)
            {
                for( int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(int i = num; 0<i; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

       public static void Pattern3(int num)
        {

         for (int i=0;i<num; i++)
            {
                for(int j=i; j<num; j++)
                {
                    Console.Write("*");
                }
                for(int j = num; j < num + 1; j++)
                {
                    if(i == 0) { Console.Write("#"); } else { Console.Write(" "); }

                }
                for(int j = i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int j = i; j < num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number:");
            var  number = Console.ReadLine();
            int num = Convert.ToInt32(number);

            Pattern1(num);

            Console.WriteLine();

            Pattern2(num);

            Console.WriteLine();

            Pattern3(num);


        }
    }
}
