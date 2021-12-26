using System.Collections.Generic;

namespace NongSan.API.Domain.Models
{
    public class Supplier : BaseEntity
    {
        public string Email { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
