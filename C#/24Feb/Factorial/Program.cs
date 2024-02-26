using System.Diagnostics.CodeAnalysis;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
             * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */
            int factorial = 1;
            int number = 5;

            while (0 < number)
            {
                factorial *= number;
                number--;
            }
            Console.WriteLine($"factorial is : {factorial}");
        }
    }
}
