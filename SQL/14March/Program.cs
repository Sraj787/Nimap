﻿using System.Net.Security;

namespace ArraySUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 10, 60, 50, 10, 20, 50 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1;j < array.Length; j++)
                {
                    int sum = 0;
                    sum = array[i] + array[j];

                    if(sum == 100)
                    {
                        Console.WriteLine(array[i]+ " " + array[j]+ "=" + sum);
                    }
                }
            }
        }
    }
}
