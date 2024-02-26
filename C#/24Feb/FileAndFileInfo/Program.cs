namespace FileAndFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\somefile.jpg", @"d:\somefile.jpg");
            File.Delete(path);
            if(File.Exists(path))
            {

            }
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("....");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

        }
    }
}
