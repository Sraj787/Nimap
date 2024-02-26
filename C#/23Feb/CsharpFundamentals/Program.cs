
using CsharpFundamentals.maths;
namespace CsharpFundamentals
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.firstName = "Sarthak";
            person.lastName = "Rajbhar";
            person.Introduce();

            Calculator calculator = new Calculator();
            var result=calculator.Add(10, 20);
            Console.WriteLine(result);
            
        }
    }
}
