using System;

namespace MyBlog.Models
{
    public class Post
    {
        public long Id { get; set; } //Composite
        public string Title { get; set; }
        public string Description { get; set; }

        public int Rating { get; set; }
        public DateTime TimeCreated { get; set; }
    }
    public class Comment
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
