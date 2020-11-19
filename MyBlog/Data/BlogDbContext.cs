using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

namespace MyBlog.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<User>()
                  .HasOne(u => u.Profile)
                  .WithOne(p => p.User)
                  .HasForeignKey<UserProfile>(p => p.UserId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
