namespace Amazon
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new  RateCalculator();
            var rate = calculator.Calculate(this);
            Console.WriteLine("Promote logic Changed");
        }
    }
}
