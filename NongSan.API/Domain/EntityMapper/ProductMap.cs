using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NongSan.API.Domain.Models;

namespace NongSan.API.Domain.EntityMapper
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ID).HasName("pk_productid"); 
            builder.Property(x => x.ID)
                .HasColumnName("ID")
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(x => x.Name)
                .HasColumnName("ProductName")
                .IsRequired();
            builder.Property(x => x.CategoryID)
                .HasColumnName("CategoryID");
            builder.Property(x => x.SupplierID).HasColumnName("SupplierID");

            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(k => k.CategoryID).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Supplier).WithMany(x => x.Products).HasForeignKey(f => f.SupplierID).OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class ProductImageMap : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(x => x.ID).HasName("pk_productimageid");
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.HasOne(x => x.Product).WithMany(x => x.ProductImages).HasForeignKey(k => k.ProductID).OnDelete(DeleteBehavior.Cascade);
        }
    }
}