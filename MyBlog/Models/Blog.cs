﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Post
    {
        public long Id { get; set; } //Composite
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Sub
    {
        public int BlogId { get; set; }
        public string UserId { get; set; }
    }
}
