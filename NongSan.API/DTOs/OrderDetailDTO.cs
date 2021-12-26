using NongSan.API.Domain.Models;

namespace NongSan.API.DTOs
{
    public class OrderDetailDTO:Base
    {
        public int Quantity { get; set; }
        public string ProductID { get; set; }
        public string OrderID { get; set; }
    }
}
