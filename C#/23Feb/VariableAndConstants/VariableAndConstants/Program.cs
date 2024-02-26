namespace VariableAndConstants
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte number=2;
            int count = 10;
            float totalFloat = 20.6f;
            char character = 'a';
            string firstName = "Mosh";
            bool isWoking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalFloat);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWoking);

            //for print the output use console.WriteLine();
            Console.WriteLine();

            //To check the range of the save number in byte
            Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue);

            //Using the const keyword to fixed value of the variable after intializing value cannot be change
            const float pi = 3.14f;
            Console.WriteLine("pi value:"+pi);

               
               
        }   
    }
}
