using NongSan.API.Domain.Models;
namespace NongSan.API.DTOs
{
    public class ShoppingCartDTO : Base
    {
        public string CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
