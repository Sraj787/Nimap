namespace InheritanceExample
{
    internal partial class Program
    {
        public class PresentationObject
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public void copy()
            {
                Console.WriteLine("Object copied to clipboard");
            }
            public void Duplicate()
            {
                Console.WriteLine("Object was Duplicate");
            }
        }
    }
}
