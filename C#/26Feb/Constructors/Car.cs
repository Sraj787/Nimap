namespace Constructors
{
    internal partial class Program
    {
        public class Car : Vehicle
        {
            public Car(string registrationNumber)
                :base (registrationNumber)
            {
                Console.WriteLine($"Car is being initailized {registrationNumber}");
            }
        }
    }
}
