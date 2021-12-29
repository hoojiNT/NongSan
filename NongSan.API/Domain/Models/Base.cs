using System;

namespace NongSan.API.Domain.Models
{
    public class Base
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
