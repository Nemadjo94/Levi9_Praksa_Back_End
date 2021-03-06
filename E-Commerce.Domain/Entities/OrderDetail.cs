﻿using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Domain.Entities
{
    public class OrderDetail
    {
        public Guid OrderId { get; set; }
        public string ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
