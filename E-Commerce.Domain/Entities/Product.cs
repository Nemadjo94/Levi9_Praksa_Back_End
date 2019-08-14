using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public bool Discontinued { get; set; }

        public Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; private set; }

    }
}
