using NongSan.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongSan.API.Domain.EntityMapper
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.ID).HasName("UserId");
            builder.Property(x => x.ID).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(c => c.Phone)
                .HasColumnType("NVARCHAR(15)")
                .IsRequired();

            builder.Property(c => c.Address)
                .HasColumnType("NVARCHAR(1000))")
                .IsRequired();

            builder.Property(c => c.Gender)
                .HasColumnType("BIT")
                .HasDefaultValue(true);
        }
    }
}
