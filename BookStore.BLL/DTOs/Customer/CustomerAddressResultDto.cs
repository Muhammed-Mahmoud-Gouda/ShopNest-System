namespace ShopNest.BLL.DTOs.Customer
{
    public class CustomerAddressResultDto
    {
        public int Id { get; set; }
        public string? Label { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string? PostalCode { get; set; }
        public bool IsDefault { get; set; }
    }
}