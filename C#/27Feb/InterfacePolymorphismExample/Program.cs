using System.Net.Mail;

namespace InterfacePolymorphismExample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
           var encode = new VideoEncoder();
            encode.RegistrationNotificationChannel(new MailNotifactionChannel());
            encode.RegistrationNotificationChannel(new SmsNotificationChannel());
            encode.Encode(new Video());
        }
    }
}
