using System.ComponentModel.DataAnnotations;

namespace ShopNest.Web.ViewModels.Order
{
    public class OrderItemViewModel
    {
        [Required(ErrorMessage = "Product is required")]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}