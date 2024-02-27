namespace ExceptionExample2
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access Youtube web Service
                //Read data
                //Create a list of video object
                throw new Exception("opps Some Low level Youtube Error ");

            }catch (Exception ex)
            {
                throw new YoutubeException("could not fetch the videos from Youtube",ex);
            }
        }
    }
}
