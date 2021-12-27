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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.ID).HasName("customerid_pk");
            builder.Property(x => x.ID).ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("CustomerName")
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
