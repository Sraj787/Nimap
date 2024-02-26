using System.Collections;
using System.Runtime.CompilerServices;

namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            var anotherlist = new List<int>();
            var names = new List<string>();
            anotherlist.Add(1);
        }
    }
}
