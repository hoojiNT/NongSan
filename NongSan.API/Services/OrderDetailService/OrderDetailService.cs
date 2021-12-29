using NongSan.API.Domain.Models;
using NongSan.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.OrderDetailService
{
    public class OrderDetailService : IOrderDetailService
    {
        private IRepository<OrderDetail> repo;
        public OrderDetailService(IRepository<OrderDetail> repo)
        {
            this.repo = repo;
        }
        public void DeleteOrderDetail(int id)
        {
            OrderDetail OrderDetail = GetOrderDetail(id);
            repo.Delete(OrderDetail);
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return repo.GetAll();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return repo.Get(id);
        }

        public void InsertOrderDetail(OrderDetail OrderDetail)
        {

            repo.Insert(OrderDetail);
        }

        public void UpdateOrderDetail(OrderDetail OrderDetail)
        {
            repo.Update(OrderDetail);
        }
    }
}
