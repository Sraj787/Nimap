using System.Security.Cryptography.X509Certificates;

namespace StackExcercise
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var  stack = new Stack();
            int ini = 1;
            int last = 5;

            for(int i=ini;i<=last;i++)
            {
                stack.Push(i);
            }

            for (int i = ini; i <= last; i++)
           {
                Console.WriteLine(stack.Pop(i)); 
            }

            stack.Clear();

            //stack is empty 
            for (int i = ini; i <= last; i++)
            {
                Console.WriteLine(stack.Pop(i));
            }
        }
    }
}
