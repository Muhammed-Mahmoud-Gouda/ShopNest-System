namespace ShopNest.BLL.DTOs.Product
{
    public class ProductImageResultDto
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public bool IsMain { get; set; }
        public int DisplayOrder { get; set; }
    }
}