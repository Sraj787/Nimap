namespace Helloworld1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            const float Pi = 3.14f;
            decimal num = 3.33m;
            Console.WriteLine("Hello, World!"+ number );
            Console.WriteLine("Pi value is: " + Pi);
            Console.WriteLine("Decimal Number is:" + num);

            //Overflowing
            checked
            {
                byte numberByte = 255;
                numberByte = numberByte + 1;
                Console.WriteLine(numberByte);
            }





        }
    }
}
