﻿namespace PrimeNumber4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int number = 8;
            int temp = 0;
            //Empty String
            String primeNumbers = "";

            for (int i = 1; i <= 100; i++)
            {
                int counter = 0;
                for (int num = i; num >= 1; num--)
                {
                    if (i % num == 0)
                    {
                        counter = counter + 1;
                    }
                }
                if (counter == 2)
                {
                    //Appended the Prime number to the String
                    primeNumbers = primeNumbers + (i * i) + " ";
                    temp++;
                }
                if (temp == number)
                {
                    break;
                }
            }           
                Console.WriteLine("Prime numbers from 1 to 100 are :");
                Console.WriteLine(primeNumbers);

        }
    }
}
    

