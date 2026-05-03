namespace ShopNest.BLL.DTOs.Customer
{
    public class CustomerResultDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; }
        public int OrdersCount { get; set; }
        public List<CustomerAddressResultDto> Addresses { get; set; } = new();
    }
}