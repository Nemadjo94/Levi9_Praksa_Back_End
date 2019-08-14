using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Application.Categories.Queries
{
    public class GetCategoryPreviewQuery : IRequest<List<CategoryPreviewDto>>
    {
        public Guid CategoryId { get; set; }
    }
}
