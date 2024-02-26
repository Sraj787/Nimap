namespace StringFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Sarthak Rajbhar ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName: "+firstName);
            Console.WriteLine("Lastname : " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName : " + names[0]);
            Console.WriteLine("LastName : "+ names[1]);

            //Replace the Text
            Console.WriteLine(fullName.Replace("Sarthak", "Mosh"));

            var str = "25";
           var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 23.2f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));

        }
    }
}
