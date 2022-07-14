using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Services.Catalog.Products.DTOs
{
    public class ProductViewModel
    {
        // Model Product
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public bool? IsFeatured { get; set; }

        // Model ProductTranslation
        public string? Name { set; get; }
        public string? Description { set; get; }
        public string? Details { set; get; }
        public string? SeoDescription { set; get; }
        public string? SeoTitle { set; get; }

        public string? SeoAlias { get; set; }
        public string? LanguageId { set; get; }
        public List<string> Categories { get; set; } = new List<string>();
    }
}
