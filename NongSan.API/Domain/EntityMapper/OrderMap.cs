using NongSan.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NongSan.API.Domain.EntityMapper
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.ID).HasName("pk_orderid");
            builder.Property(x => x.CustomerID).HasColumnName("CustomerID").ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.OrderDetailID).HasColumnName("OrderDetailID");
            builder.HasMany(order => order.OrderDetails)
                .WithOne()
                //.HasForeignKey(x => x.OrderID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
