using Microsoft.AspNetCore.Mvc.Rendering;
using ShopNest.BLL.DTOs.Product;

namespace ShopNest.Web.ViewModels.Product
{
    public class ProductIndexViewModel
    {
        public IEnumerable<ProductResultDto> Products { get; set; } = new List<ProductResultDto>();

        
        public string? SearchTerm { get; set; }
        public int? CategoryId { get; set; }
        public bool? IsActive { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

      
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; } = 10;

        
        public SelectList? Categories { get; set; }
    }
}