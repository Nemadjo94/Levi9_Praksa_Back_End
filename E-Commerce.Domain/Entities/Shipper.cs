using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{
    public class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public Guid ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; private set; }
    }
}
