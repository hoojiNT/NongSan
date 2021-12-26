using NongSan.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.OrderService
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrder(string id);
        void InsertOrder(Order Order);
        void UpdateOrder(Order Order);
        void DeleteOrder(string id);
    }
}
