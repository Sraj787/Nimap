namespace ExceptionExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
               var api = new YoutubeApi();
                var videos = api.GetVideos("Mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected erro occurred.");
            }
        }
    }
}
