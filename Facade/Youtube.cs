using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Youtube
    {
        public void Login(string user, string password)
        {
            Console.WriteLine("Logging into the system");
        }

        public void Logout()
        {
            Console.WriteLine("Logging out of the system");
        }

        public void UploadVideo(string videoPath)
        {
            Console.WriteLine("Uploading Video...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Video has been uploaded...");
        }

        public void GetChannelName()
        {
            
        }

        public void GetPlaylists()
        {
            
        }

        public void GetMonetizationInfo()
        {
            
        }

        /// many others
    }
}
