using NongSan.API.Domain.Models;
using NongSan.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.OrderService
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> repo;
        public OrderService(IRepository<Order> repo)
        {
            this.repo = repo;
        }
        public void DeleteOrder(string id)
        {
            Order Order = GetOrder(id);
            repo.Delete(Order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return repo.GetAll();
        }

        public Order GetOrder(string id)
        {
            return repo.Get(id);
        }

        public void InsertOrder(Order Order)
        {

            repo.Insert(Order);
        }

        public void UpdateOrder(Order Order)
        {
            repo.Update(Order);
        }
    }
}
