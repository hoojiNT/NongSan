using NongSan.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongSan.API.DTOs
{
    public class SupplierDTO: BaseEntity
    {
        public string Email { get; set; }
    }
}
