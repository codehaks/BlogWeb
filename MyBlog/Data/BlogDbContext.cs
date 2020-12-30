using Microsoft.EntityFrameworkCore;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
          : base(options) { }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("my_seq").
                StartsAt(1000)
                .IncrementsBy(1);

            modelBuilder.Entity<Blog>()
                .Property(b => b.Id)
                .UseHiLo("my_seq");

        }

    }
}
