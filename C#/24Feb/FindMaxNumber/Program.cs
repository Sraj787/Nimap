namespace FindMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Write a program and ask the user to enter a series of numbers separated by comma.
             *  Find the maximum of the numbers and display it on the console.
             *  For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
             */
            var userIn = Console.ReadLine();
            string[] array = userIn.Split(',');
            int max = Convert.ToInt32(array[0]);

            for (int i = 0; i < array.Length; i++)
            {
                if (Convert.ToInt32(array[i]) > max){
                    max = Convert.ToInt32(array[i]);
                }
                
            }

            Console.WriteLine($"Max Number is: {max}");
        }
    }
}
