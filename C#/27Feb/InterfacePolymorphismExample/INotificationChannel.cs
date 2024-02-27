namespace InterfacePolymorphismExample
{
    internal partial class Program
    {
        interface INotificationChannel
        {
            void Send(Message message);
        }
    }
}
