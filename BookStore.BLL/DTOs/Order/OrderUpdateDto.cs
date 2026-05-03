using ShpoNest.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.BLL.DTOs.Order
{
    public class OrderUpdateDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public OrderStatus Status { get; set; }

        [StringLength(1000, ErrorMessage = "Notes cannot exceed 1000 characters")]
        public string? Notes { get; set; }
    }
}