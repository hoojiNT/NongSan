using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongSan.API.Domain.Models
{
    public  class ProductImage:Base
    {
        public string ImagePath { get; set; }
        public bool IsDefault { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
