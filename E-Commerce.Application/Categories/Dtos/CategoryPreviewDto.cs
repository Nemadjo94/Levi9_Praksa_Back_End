using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace E_Commerce.Application.Categories
{
    public class CategoryPreviewDto
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<ProductPreviewDto> Products { get; set; }

        public CategoryPreviewDto()
        {
            Products = new List<ProductPreviewDto>();
        }

        public static Expression<Func<CategoryPreviewDto, CategoryPreviewDto>> Projection
        {
            get
            {
                return c => new CategoryPreviewDto
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    Description = c.Description,
                    Products = c.Products.AsQueryable()
                        .Select(ProductPreviewDto.Projection)
                        .Take(5)
                        .OrderBy(p => p.ProductName)
                        .ToList()
                };
            }
        }
    }
}
