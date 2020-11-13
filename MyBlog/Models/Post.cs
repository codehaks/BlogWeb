using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models
{
    public class Post
    {
        public long Id { get; set; } //Composite
        public string Title { get; set; }
        public string Description { get; set; }

        public int DaysAgo
        {
            get
            {
                return (DateTime.Now - TimeCreated).Days;
            }
        }

        public int Rating { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeInsert { get; set; }
    }
}
