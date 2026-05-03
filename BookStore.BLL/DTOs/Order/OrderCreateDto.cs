using System.ComponentModel.DataAnnotations;

namespace ShopNest.BLL.DTOs.Order
{
    public class OrderCreateDto
    {
        [Required(ErrorMessage = "Customer is required")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Shipping address is required")]
        public int ShippingAddressId { get; set; }

        [StringLength(1000, ErrorMessage = "Notes cannot exceed 1000 characters")]
        public string? Notes { get; set; }

        [MinLength(1, ErrorMessage = "Order must have at least one item")]
        public List<OrderItemCreateDto> Items { get; set; } = new();
    }
}