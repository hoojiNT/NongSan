namespace NongSan.API.Domain.Models
{
    public class OrderDetail : Base
    {
        public int Quantity;
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int OrderID;
        public Order Order { get; set; }
    }
}
