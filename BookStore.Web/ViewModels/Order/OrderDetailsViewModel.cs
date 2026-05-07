using ShopNest.BLL.DTOs.Order;
using ShpoNest.Models.Enums;

namespace ShopNest.Web.ViewModels.Order
{
    public class OrderDetailsViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingCity { get; set; }
        public string? ShippingPostalCode { get; set; }
        public string? Notes { get; set; }
        public List<OrderItemResultDto> Items { get; set; } = new();
    }
}