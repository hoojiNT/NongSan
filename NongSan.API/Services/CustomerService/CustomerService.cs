using NongSan.API.Domain.Models;
using NongSan.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> repo;
        public CustomerService(IRepository<Customer> repo)
        {
            this.repo = repo;
        }
        public void DeleteCustomer(string id)
        {
            Customer customer = GetCustomer(id);
            repo.Delete(customer);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return repo.GetAll();
        }

        public Customer GetCustomer(string id)
        {
            return repo.Get(id);
        }

        public void InsertCustomer(Customer customer)
        {
            repo.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            repo.Update(customer);
        }
    }
}
