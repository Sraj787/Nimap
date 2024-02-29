﻿namespace ThirdHighestNumber
{
    internal class Program
    {
        public static int ThirdHighestNumber(int[] arr)
        {
            int first = arr[0];
            int second = arr[0];
            int third = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    third = second;
                    second = first;
                    first = arr[i];
                }
                if (arr[i] > second && arr[i] != first)
                {
                    third = second;
                    second = arr[i];

                }
                if (arr[i]>third &&  arr[i] != second)
                {
                    third = arr[i];
                }
            }
            return third;
        }
        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 7, 3, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            Console.WriteLine("ThirdHighest Element In Array: "+ThirdHighestNumber(arr));
        }
    }
}
