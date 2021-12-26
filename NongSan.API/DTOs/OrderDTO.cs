using NongSan.API.Domain.Models;
using System;

namespace NongSan.API.DTOs
{
    public class OrderDTO:Base
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
        public string OrderDetailID { get; set; }

    }
}
