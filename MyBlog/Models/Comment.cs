using System;

namespace MyBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
