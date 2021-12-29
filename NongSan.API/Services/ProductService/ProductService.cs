using NongSan.API.Domain.Models;
using NongSan.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductService
{
    public class ProductService : IProductService
    {
        private IRepository<Product> repo;
        public ProductService(IRepository<Product> repo)
        {
            this.repo = repo;
        }
        public void DeleteProduct(int id)
        {
            Product Product = GetProduct(id);
            repo.Delete(Product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return repo.GetAll();
        }

        public Product GetProduct(int id)
        {
            return repo.Get(id);
        }

        public void InsertProduct(Product Product)
        {

            repo.Insert(Product);
        }

        public void UpdateProduct(Product Product)
        {
            repo.Update(Product);
        }
    }
}
