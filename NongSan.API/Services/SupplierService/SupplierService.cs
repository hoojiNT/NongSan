using NongSan.API.Domain.Models;
using NongSan.API.Repository;
using ServicesLayer.SupplierService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.SupplierService
{
    public class SupplierService : ISupplierService
    {
        private IRepository<Supplier> repo;
        public SupplierService(IRepository<Supplier> repo)
        {
            this.repo = repo;
        }
        public void DeleteSupplier(int id)
        {
            Supplier Supplier = GetSupplier(id);
            repo.Delete(Supplier);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return repo.GetAll();
        }

        public Supplier GetSupplier(int id)
        {
            return repo.Get(id);
        }

        public void InsertSupplier(Supplier Supplier)
        {

            repo.Insert(Supplier);
        }

        public void UpdateSupplier(Supplier Supplier)
        {
            repo.Update(Supplier);
        }
    }
}
