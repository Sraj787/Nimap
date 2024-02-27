
namespace EventExample
{
    public class MailService
    { 
    public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an Email...");
        }
    }

}
