namespace Constructors
{
    internal partial class Program
    {
        public class Vehicle
        {
            private readonly string _registrationNumber;


            //public Vehicle()
            //{
            //   Console.WriteLine("Vehicle is being initialized.");
            //}
            public Vehicle(string registrationNumber)
            {
                _registrationNumber = registrationNumber;

                Console.WriteLine($"Vehicle is being initailized {registrationNumber}");
            }
        }
    }
}
