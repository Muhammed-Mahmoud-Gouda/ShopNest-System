using Microsoft.AspNetCore.Mvc.Rendering;
using ShopNest.BLL.DTOs.Customer;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.Web.ViewModels.Order
{
    public class OrderCreateViewModel
    {
        [Required(ErrorMessage = "Customer is required")]
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Shipping address is required")]
        [Display(Name = "Shipping Address")]
        public int ShippingAddressId { get; set; }

        [StringLength(1000, ErrorMessage = "Notes cannot exceed 1000 characters")]
        [Display(Name = "Notes")]
        public string? Notes { get; set; }

        
        public List<OrderItemViewModel> Items { get; set; } = new();

        
        public SelectList? Customers { get; set; }
        public SelectList? Addresses { get; set; }
        public SelectList? Products { get; set; }
    }
}