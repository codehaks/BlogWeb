﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyBlog.Models
{
    // Dependent
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; set; }
        public int BlogId { get; set; }

        public List<Comment> Comments { get; set; }

        public Blog Blog { get; set; }
        public Collection<Tag> Tags { get; set; }
    }

    public class Tag
    {
        public string TagId { get; set; }
        public Collection<Post> Posts { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }

        public long PostId { get; set; }
    }
}
