using System;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("Intro to C#", "Rick Oak", 250);
            video1.AddComment(new Comment("Alice", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
            video1.AddComment(new Comment("Charlie", "Good to add another language to my repertoire!"));
            video1.Display();

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video1.GetComments())
            {
                comment.Display();
            }

            Video video2 = new Video("Abstraction", "Rick Oak", 250);
            video2.AddComment(new Comment("Alice", "I took great notes from this!"));
            video2.AddComment(new Comment("Bob", "Very reminiscent!"));
            video2.AddComment(new Comment("Charlie", "I will be sure to review record of this!"));
            video2.Display();

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video2.GetComments())
            {
                comment.Display();
            }

            Video video3 = new Video("Encapsulation", "Rick Oak", 250);
            video3.AddComment(new Comment("Alice", "I will remember this for quite some time!"));
            video3.AddComment(new Comment("Bob", "I love those verses!"));
            video3.AddComment(new Comment("Charlie", "I will be sure to review record of this!"));
            video3.Display();

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video3.GetComments())
            {
                comment.Display();
            }

            Video video4 = new Video("Further Foundation", "Rick Oak", 250);
            video4.AddComment(new Comment("Alice", "This seems familiar!"));
            video4.AddComment(new Comment("Bob", "Is that what this was?"));
            video4.AddComment(new Comment("Charlie", "Glad to see this online!"));
            video4.Display();

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video4.GetComments())
            {
                comment.Display();
            }
        }
    }
}
