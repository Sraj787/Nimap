using System.Security.Cryptography.X509Certificates;

namespace StackExcercise
{
    internal partial class Program
    {
        public class Stack
        {
            private readonly List<object> _stack = new List<object>();

            public void Push(Object obj)

            {
                if (obj == null)
                    throw new InvalidOperationException("You can not null onject in stack.");
                _stack.Add(obj);
            }

            public Object Pop(int count)
            {
                if (_stack.Count == 0)
                    throw new InvalidOperationException("Stack is Empty.");
                
                var index = _stack.Count - 1;

                var returnTo = _stack[index];
                _stack.RemoveAt(index);

                return returnTo;
            }

            public void Clear()
            {
                _stack.Clear();
            }

        }
    }
}
