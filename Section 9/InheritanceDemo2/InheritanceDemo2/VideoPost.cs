using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace InheritanceDemo2
{
    class VideoPost : Post
    {
        public string VideoURL { get; set; }
        
        public int Length { get; set; }

        protected bool isPlaying = false;

        Timer timer;

        private int currentime = 0;

        // constructor
        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
        }

        // toString method
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", this.ID, this.SendByUsername, this.VideoURL, this.Length);
        }

        // play and pause video method
        public void play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                timer = new Timer(callback, null, 0, 1000);
            }
          
            // writes the current duration of the video;
            
        }

        private void callback(Object o)
        {
            if(currentime < Length)
            {
                currentime++;
                Console.WriteLine("video is at {0}", currentime);
                GC.Collect();
            }
            else
            {
                pause();
            }
        }

        public void pause()
        {
            if (isPlaying)
            {
                isPlaying = false;
                // stop timer
                // write "Stopped at {0}s" to console.
                Console.WriteLine("Stopped at {0}s", currentime);
                currentime = 0;
                timer.Dispose();
            }
            

        }





    }
}
