using System.Collections.Generic;

namespace NongSan.API.Domain.Models
{
    public class ShoppingCart : Base
    {
        public string CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
