using NongSan.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NongSan.API.Domain.EntityMapper
{
    public class OrderDetailMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => x.ID).HasName("pk_orderdetailid");
            builder.Property(x => x.ProductID).HasColumnName("ProductID").ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.OrderID).HasColumnName("OrderID");
            builder.Property(x => x.Quantity).HasColumnName("Quantity");
            builder.HasOne(x=>x.Product).WithMany().HasForeignKey(k => k.ProductID);
            builder.HasOne(x=>x.Order).WithMany().HasForeignKey(f => f.OrderID);
        }
    }
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.ID).HasName("pk_contactid");
            builder.Property(x => x.ID).HasColumnName("ContactID").ValueGeneratedOnAdd();
        }
    }
}
