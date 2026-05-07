using ShopNest.BLL.DTOs.Category;

namespace ShopNest.Web.ViewModels.Category
{
    public class CategoryIndexViewModel
    {
        public IEnumerable<CategoryResultDto> Categories { get; set; }
        public string? SearchTerm { get; set; }
        public int TotalCount { get; set; }

        // Pagination
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }
        public int PageSize { get; set; } = 10;
    }
}