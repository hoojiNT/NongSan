using NongSan.API.Domain.Models;

namespace NongSan.API.DTOs
{
    public class ProductImageDTO:Base
    {
        public string ImagePath { get; set; }
        public bool IsDefault { get; set; }
        public string ProductID { get; set; }
    }
}
