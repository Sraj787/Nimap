using System.Diagnostics.Tracing;
using System.Globalization;

namespace CalculateSum
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             *Write a program and continuously ask the user to enter a number or "ok" to exit.
             *Calculate the sum of all the previously entered numbers and display it on the console.
             */

            bool f = true;
            var sum = 0;
            
            Console.WriteLine("If you wont to exit please Enter ok");
            Console.WriteLine("Please Enter the Number: ");
            while (f)
            {
                var number = Console.ReadLine();

                if (number.ToLower() == "ok") {
                    f = false;
                } else
                { 
                    sum += Convert.ToInt32(number);
                }
                    
            }
            Console.WriteLine("Total Sum Of the All Number Is: " +sum);
            
        }
    }
}
