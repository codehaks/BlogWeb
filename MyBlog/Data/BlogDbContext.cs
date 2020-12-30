using Microsoft.EntityFrameworkCore;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MyBlog.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
          : base(options) { }

        public DbSet<Blog> Blogs { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker
                .Entries()
                .Where(e => e.Entity is ITimeCreated && e.State == EntityState.Added)
                .Select(e => e.Entity as ITimeCreated))
            {
                if (entry.TimeCreated <= DateTime.MinValue)
                {
                    entry.TimeCreated = DateTime.Now;
                }
            }

            foreach (var entry in ChangeTracker
               .Entries()
               .Where(e => e.Entity is ITimeModified && e.State == EntityState.Modified)
               .Select(e => e.Entity as ITimeModified))
            {
                entry.TimeModfied = DateTime.Now;
            }

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker
               .Entries()
               .Where(e => e.Entity is ITimeCreated && e.State == EntityState.Added)
               .Select(e => e.Entity as ITimeCreated))
            {
                if (entry.TimeCreated <= DateTime.MinValue)
                {
                    entry.TimeCreated = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Blog>()
            //    .Property(b => b.TimeCreated)
            //    .HasDefaultValueSql("GETDATE()");

            modelBuilder.HasSequence<int>("my_seq").
                StartsAt(1000)
                .IncrementsBy(1);

            modelBuilder.Entity<Blog>()
                .Property(b => b.Id)
                .UseHiLo("my_seq");

        }

    }
}
