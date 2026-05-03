namespace ShopNest.BLL.DTOs.Category
{
    public class CategoryResultDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public bool IsActive { get; set; }
        public int ProductsCount { get; set; }
    }
}