using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var youtubeFacade = new YouTubeFacade();
            youtubeFacade.Login("user", "password");
            youtubeFacade.UploadVideo("C:\\video.mp4");
            youtubeFacade.Logout();
        }
    }
}
