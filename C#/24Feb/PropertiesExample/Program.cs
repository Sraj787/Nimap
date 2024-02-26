namespace PropertiesExample
{
    internal class Program
    {
        public class Person
        {
            public DateTime Birthdate { get; set; }
            public int Age
            {
                get
                {
                    var timeSpan = DateTime.Today - Birthdate;
                    var year = timeSpan.Days / 365;
                    return year;

                }
            }
        }
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1998, 1, 1);
            Console.WriteLine(person.Age);
        }
    }
}
