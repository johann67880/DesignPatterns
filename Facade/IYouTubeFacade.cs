using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public interface IYouTubeFacade
    {
        public void Login(string username, string password);
        public void Logout();
        public void UploadVideo(string videoPath);
    }
}
