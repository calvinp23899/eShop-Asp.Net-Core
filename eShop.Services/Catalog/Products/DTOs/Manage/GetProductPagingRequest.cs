using eShop.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Services.Catalog.Products.DTOs.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string? Keyword { get; set; }
        public List<int>? CategoryIDs { get; set; }
    }
}
