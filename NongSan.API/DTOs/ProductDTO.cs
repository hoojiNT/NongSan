using NongSan.API.Domain.Models;
using System;

namespace NongSan.API.DTOs
{
    public class ProductDTO: Base
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
        public string CategoryID { get; set; }
    }
}
