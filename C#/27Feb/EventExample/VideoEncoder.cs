namespace EventExample
{
    internal partial class Program
    {
        public class VideoEncoder
        {//1- define a delegate
         //2- define an event based on that delegate
         //3-raise the event

            public delegate void VideoEncodeEventHandler(object sourse, VideoEventArgs args);
            public event VideoEncodeEventHandler VideoEncoded;
            public void Encode(Video video)
            {
                Console.WriteLine("Encoding video.....");
                Thread.Sleep(3000);
                OnVideoEncoded(video);
            }
            protected virtual void OnVideoEncoded(Video video)
            {
                if(VideoEncoded != null)
                    VideoEncoded(this,new VideoEventArgs(){ Video = video});
                

                
            }
        }
    }
}
