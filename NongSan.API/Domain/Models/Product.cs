using System;
using System.Collections.Generic;

namespace NongSan.API.Domain.Models
{
    public class Product : BaseEntity
    {
        public double Price { get; set; }
        public double OriginalPrice { get; set; }
        public bool IsDiscount { get; set; }
        public int ViewCount { get; set; }
        public int DiscountAmount { get; set; }
        public string Detail { get; set; }
        public DateTime DateManufacturingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; }


        public string SupplierID { get; set; }
        public virtual Supplier Supplier { get; set; }

        public string CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public string ProductImageID { get; set; }
        public virtual List<ProductImage> ProductImages { get; set; }
    }
}
