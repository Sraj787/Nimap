namespace InterfacePolymorphismExample
{
    internal partial class Program
    {
        public class MailNotifactionChannel : INotificationChannel
        {
            void INotificationChannel.Send(Message message)
            {
                Console.WriteLine("Sending Mail...");
            }
        }
    }
}
