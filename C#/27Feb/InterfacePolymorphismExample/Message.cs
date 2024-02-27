using System.Threading.Channels;

namespace InterfacePolymorphismExample
{
    internal partial class Program
    {
        public class Message{

            public void Send()
            {
                Console.WriteLine("Sending mail..");
            }
        
        }
    }
}
