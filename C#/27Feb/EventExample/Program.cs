namespace EventExample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
           var video = new Video();
           var videoEncoder = new VideoEncoder();
           var mailService = new MailService();
           videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
           

            videoEncoder.Equals(video);
        }
    }

}
