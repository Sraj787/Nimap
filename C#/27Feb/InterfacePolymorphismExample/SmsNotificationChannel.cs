namespace InterfacePolymorphismExample
{
    internal partial class Program
    {
        public class SmsNotificationChannel : INotificationChannel
        {
            void INotificationChannel.Send(Message message)
            {
                Console.WriteLine("Sending sms...");
            }
        }
    }
}
