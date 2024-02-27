namespace LambdaExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //args => expression 

            Func<int, int> square = number => number * number;
            Console.WriteLine(square(3));

            const int factor = 5;
            Func<int, int> mutipler = n => n * factor;
            Console.WriteLine(mutipler(3));
        }
       /* static  int Square(int number)
        {
            return number * number;
        }*/
    }
}
