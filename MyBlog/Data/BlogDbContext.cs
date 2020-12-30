using Microsoft.EntityFrameworkCore;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Data
{
    public class BlogDbContext:DbContext
    {

        public DbSet<Blog> Blogs { get; set; }
    }
}
