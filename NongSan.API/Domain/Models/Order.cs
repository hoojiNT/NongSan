using System;
using System.Collections.Generic;

namespace NongSan.API.Domain.Models
{
    public class Order : Base
    {
        public double TotalMoney { get; set; }
        public string Payment { get; set; }
        public DateTime BookingDate { get; set; }
        public string DeliveryData { get; set; }
        public string ShippingWay { get; set; }
        public string State { get; set; }
        public string Note { get; set; }
        public double TransportFee { get; set; }

        public string CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string OrderDetailID { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
