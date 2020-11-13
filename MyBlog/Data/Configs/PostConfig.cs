using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Data.Configs
{
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.Rating).HasDefaultValue(3);
            builder.Property(p => p.TimeCreated).HasDefaultValueSql("GETDATE()");

            builder.Ignore(p => p.DaysAgo);

            builder.Property(p => p.TimeInsert)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAdd();

        }
    }
}
