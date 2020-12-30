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
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
          : base(options) { }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("seq2")
                .StartsAt(10)
                .IncrementsBy(1000);

            modelBuilder.Entity<Blog>()
                .Property(b => b.Id)
                .UseHiLo("seq2");

            base.OnModelCreating(modelBuilder);
        }
    }
}
