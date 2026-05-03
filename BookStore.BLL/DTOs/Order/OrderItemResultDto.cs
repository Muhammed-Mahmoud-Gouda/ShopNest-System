namespace ShopNest.BLL.DTOs.Order
{
    public class OrderItemResultDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? MainImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}