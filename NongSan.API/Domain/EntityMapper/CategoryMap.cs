using NongSan.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NongSan.API.Domain.EntityMapper
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.ID).HasName("pk_categoryid");
            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd();
            builder.Property(x => x.Name)
                .HasColumnName("CategoryName")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.Description)
                .HasColumnType("NVARCHAR(1000)");
        }
    }
}