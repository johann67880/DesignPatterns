using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class YouTubeFacade : IYouTubeFacade
    {
        private Youtube youtube = new Youtube();

        public void Login(string username, string password)
        {
            youtube.Login(username, password);
        }

        public void Logout()
        {
            youtube.Logout();
        }

        public void UploadVideo(string videoPath)
        {
            youtube.UploadVideo(videoPath);
        }
    }
}
