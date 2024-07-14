
// Define the Video class

class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("where did the time go?", "somthingstupidlol", 300);
        Video video2 = new Video("strawberries are overated", "bluberrylvr", 450);
        Video video3 = new Video("THE DOWNFALL OF CSE110", "codeHATER87", 600);
        Video video4 = new Video("how to release your karma", "megalord34", 720);

        // Create comment instances and add to videos
        video1.AddComment(new Comment("coolguy13", "Great video!"));
        video1.AddComment(new Comment("earth1zflat", "Nice content."));
        video1.AddComment(new Comment("flyyyguyyy", "Very informative."));

        video2.AddComment(new Comment("supercodplayer1999", "Loved it!"));
        video2.AddComment(new Comment("fihsbrains", "Interesting perspective."));
        video2.AddComment(new Comment("tf2h8tr", "Well explained."));

        video3.AddComment(new Comment("Suslord", "Awesome video!"));
        video3.AddComment(new Comment("SLCFTW", "Good job."));
        video3.AddComment(new Comment("gheyfries", "Thanks for sharing."));

        video4.AddComment(new Comment("mamamia47", "Excellent!"));
        video4.AddComment(new Comment("joebiden1", "Very useful."));
        video4.AddComment(new Comment("pleaseletthswork", "Great explanation."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display video information and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}