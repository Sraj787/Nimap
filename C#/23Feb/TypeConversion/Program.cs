namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit TypeCasting
            byte b = 1;
            int i = b;
            Console.WriteLine(i);


            //Explicit TypeCasting
            int a = 1000;
            //byte b1 = a;//show error
            byte b1 = (byte)a;
            Console.WriteLine(b1);

            //Conversion Between Non-Compatible TypeCasting or String to number TypeCasting
            string number = "1234";
            int count = Convert.ToInt32(number);
            Console.WriteLine(count);

            //Example 1.
            try
            {
                string str = "1234";
                int bytestr = Convert.ToByte(str);
                Console.WriteLine(bytestr);

            }catch (Exception)
            {
                Console.WriteLine("the number could not be converted to a byte");
            }

            //Example 2.
            try
            {
                string word = "true";
                bool boolstr = Convert.ToBoolean(word);
                Console.WriteLine(boolstr);

            }
            catch (Exception)
            {
                Console.WriteLine("the number could not be converted to a boolean");
            }
        }
    }
}
