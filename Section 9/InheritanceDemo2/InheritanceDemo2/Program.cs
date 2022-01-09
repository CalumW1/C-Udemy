using System;

namespace InheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create regular text post and write to console
            Post post1 = new Post("test", true, "Calum");
            Console.WriteLine(post1.ToString());
            
            // create image post and write to console
            ImagePost imagePost1 = new ImagePost("testImage", "Calum", "www.google.com", true);
            Console.WriteLine(imagePost1.ToString());

            // create video post and write to console.
            VideoPost videoPost1 = new VideoPost("TestVideo", "Calum", "www.videoURL.com", true, 10);
            Console.WriteLine(videoPost1.ToString());

            Console.WriteLine("Would you like to watch the video?");
            Console.WriteLine("Enter Yes or No");
            string userInput = Console.ReadLine();

            switch (userInput) 
            {
                case "yes":
                    videoPost1.play();
                    break;
            }

            Console.ReadKey();
            videoPost1.pause();

            Console.ReadLine();
        }
    }
}
