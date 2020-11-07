using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Data.Configs
{
    public class SubConfig : IEntityTypeConfiguration<Sub>
    {
        public void Configure(EntityTypeBuilder<Sub> builder)
        {
            builder.Property(s => s.UserId).HasMaxLength(120);

            builder.HasKey(s => new { s.BlogId, s.UserId });
        }
    }
}
