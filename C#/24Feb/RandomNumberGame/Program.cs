using System;

namespace RandomNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
             *  If the user guesses the number, display “You won"; otherwise, display “You lost".
             *  (To make sure the program is behaving correctly, you can display the secret number on the console first.)
             */
            Console.WriteLine("Enter the Number:");
            int i = 4;
            
            while (0 < i)
            {
                string number = Console.ReadLine();

                var random = new Random();
                int num= random.Next(0,10);
                Console.WriteLine($"Random Number is: {num}");
                

                if(Convert.ToInt32(number) == num)
                {
                    Console.WriteLine("Won");
                    break;
                }
                else
                {
                    Console.WriteLine("Lose");
                    
                }

                i--;
                Console.WriteLine($"Remaining Chance is: {i}");
            }
            

        }
    }
}
