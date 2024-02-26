namespace ClassesExample
{
    public class Person
    {
        public string Name;
        public void Intorduce(string to)
        {
            Console.WriteLine("hi {0},i am {1}",to,Name);
        }
        public static  Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;

            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Sarthak";
            person.Intorduce("mosh");

            var person1 = Person.Parse("jhon");
            Console.WriteLine(person1.Name);
           
        }
    }
}
