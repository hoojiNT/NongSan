using NongSan.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NongSan.API.Domain.EntityMapper
{
    public class SupplierMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.ID).HasName("pk_supplierid");
            builder.Property(x => x.ID)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(x => x.Name)
                .HasColumnName("SupplierName")
                .HasColumnType("Nvarchar(100)")
                .IsRequired();
            builder.Property(x => x.Email)
                .HasColumnType("Nvarchar(100)");
            builder.Property(builder => builder.Phone).HasColumnType("Nvarchar(15)");
        }
    }
}