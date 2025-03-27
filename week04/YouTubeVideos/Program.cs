using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // create video list
        List<Video> videos = new List<Video>();

        //add videos and comments
        Video video1 = new Video("Understanding Encapsulation", "Tech Guru", 300);
        video1.AddComment("Alice", "Great explanation!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "Can you do one on inheritance?");

        Video video2 = new Video("Introduction to C#", "Code Master", 600);
        video2.AddComment("David", "Super clear and concise!");
        video2.AddComment("Eve", "Love your teaching style!");
        video2.AddComment("Frank", "Thanks for this, very helpful!");

        Video video3 = new Video("OOP Principles Explained", "Dev Simplified", 450);
        video3.AddComment("Grace", "I finally get it now!");
        video3.AddComment("Hank", "Well structured tutorial!");
        video3.AddComment("Ivy", "This was fantastic!");

        //add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //display info about videos
        foreach (var video in videos)
        {
            video.VideoInfo();
        }

    }
}