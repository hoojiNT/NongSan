using NongSan.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.SupplierService
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Supplier GetSupplier(string id);
        void InsertSupplier(Supplier Supplier);
        void UpdateSupplier(Supplier Supplier);
        void DeleteSupplier(string id);
    }
}
