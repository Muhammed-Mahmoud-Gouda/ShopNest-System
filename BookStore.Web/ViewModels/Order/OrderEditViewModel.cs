using Microsoft.AspNetCore.Mvc.Rendering;
using ShopNest.BLL.DTOs.Order;
using ShpoNest.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.Web.ViewModels.Order
{
    public class OrderEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Order Status")]
        public OrderStatus Status { get; set; }

        [StringLength(1000, ErrorMessage = "Notes cannot exceed 1000 characters")]
        [Display(Name = "Notes")]
        public string? Notes { get; set; }

       
        public string? CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string? ShippingStreet { get; set; }
        public string? ShippingCity { get; set; }
        public string? ShippingPostalCode { get; set; }
        public List<OrderItemResultDto> Items { get; set; } = new();

       
        public SelectList? Statuses { get; set; }
    }
}