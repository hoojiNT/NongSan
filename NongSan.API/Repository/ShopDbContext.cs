using NongSan.API.AutoMapper;
using NongSan.API.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NongSan.API.Domain.AuthIdentity;
using NongSan.API.Domain.EntityMapper;

namespace NongSan.API.Repository
{
    public class ShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public ShopDbContext()
        {
        }

        public ShopDbContext( DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasSequence("dbSequal").HasMin(1).HasMax(10000).StartsAt(1).IncrementsBy(1);
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new OrderDetailMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new SupplierMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
