namespace ExceptionExample2
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message,Exception innerException)
            :base(message, innerException) { 


        }
        
            
        

    }
}
