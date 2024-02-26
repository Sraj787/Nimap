namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4,5};
            numbers.Add(7);
            numbers.AddRange(new int[3] {8,6,9});

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("1 At Index: "+numbers.IndexOf(1));
   
            Console.WriteLine("Count: "+numbers.Count());

            numbers.Remove(5);
            foreach (int i in numbers)
            { Console.WriteLine(i); }
        }
    }
}
