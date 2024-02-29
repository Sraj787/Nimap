﻿namespace ReverseStringOrNumber
{
    
    internal class Program
    {

        public static string ReverseString(string s)
        {
            string reverse = "";

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                reverse = c + reverse;
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Input");
            var str = Console.ReadLine();
            Console.WriteLine("Input String: "+str);
            Console.WriteLine("Reverse String: " +ReverseString(str));
        }
    }
}
