using ShopNest.BLL.DTOs.Customer;

namespace ShopNest.Web.ViewModels.Customer
{
    public class CustomerIndexViewModel
    {
        public IEnumerable<CustomerResultDto> Customers { get; set; } = new List<CustomerResultDto>();

      
        public string? SearchTerm { get; set; }
        public bool? IsActive { get; set; }

       
        public int CurrentPage { get; set; } = 1;
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        public int PageSize { get; set; } = 10;
    }
}