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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\sqlexpress;Initial Catalog=MyBlogDb_Dev01;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
