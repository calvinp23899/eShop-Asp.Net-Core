using eShop.Services.Catalog.Products.DTOs;
using eShop.Services.Catalog.Products.DTOs.Public;
using eShop.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Services.Catalog.Products
{
    public interface IPublicProductService
    {
         PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
