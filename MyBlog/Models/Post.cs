using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; set; }

    }
}
