using E_Commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace E_Commerce.Application.Categories
{
    public class ProductPreviewDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }

        public static Expression<Func<Product, ProductPreviewDto>> Projection
        {
            get
            {
                return p => new ProductPreviewDto
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice
                };
            }
        }
    }
}
