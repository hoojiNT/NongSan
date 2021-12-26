using NongSan.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductService
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct(string id);
        void InsertProduct(Product Product);
        void UpdateProduct(Product Product);
        void DeleteProduct(string id);
    }
}
