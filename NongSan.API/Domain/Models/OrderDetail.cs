namespace NongSan.API.Domain.Models
{
    public class OrderDetail : Base
    {
        public int Quantity;
        public string ProductID { get; set; }
        public Product Product { get; set; }

        public string OrderID;
        public Order Order { get; set; }
    }
}
