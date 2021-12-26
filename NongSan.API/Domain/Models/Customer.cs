using System.Collections;
using System.Collections.Generic;

namespace NongSan.API.Domain.Models
{
    public class Customer : Person
    {
        IEnumerable<Order> Orders;
    }
}
