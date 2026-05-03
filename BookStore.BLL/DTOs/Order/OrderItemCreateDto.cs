using System.ComponentModel.DataAnnotations;

namespace ShopNest.BLL.DTOs.Order
{
    public class OrderItemCreateDto
    {
        [Required(ErrorMessage = "Product is required")]
        public int ProductId { get; set; }

        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100")]
        public int Quantity { get; set; }
    }
}