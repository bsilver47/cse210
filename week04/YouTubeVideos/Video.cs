using System;

namespace YouTubeVideos
{
    class Video
    {
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;

        public Video(string title, string author, int length, List<Comment> comments = null)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = comments ?? new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Number of Comments: {_comments.Count}");
        }
    }
}