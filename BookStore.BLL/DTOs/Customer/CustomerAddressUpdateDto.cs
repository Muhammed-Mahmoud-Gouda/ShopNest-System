using System.ComponentModel.DataAnnotations;

namespace ShopNest.BLL.DTOs.Customer
{
    public class CustomerAddressUpdateDto
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [StringLength(50, ErrorMessage = "Label cannot exceed 50 characters")]
        public string? Label { get; set; }

        [Required(ErrorMessage = "Street is required")]
        [StringLength(300, ErrorMessage = "Street cannot exceed 300 characters")]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(100, ErrorMessage = "City cannot exceed 100 characters")]
        public string City { get; set; }

        [StringLength(20, ErrorMessage = "Postal code cannot exceed 20 characters")]
        public string? PostalCode { get; set; }

        public bool IsDefault { get; set; }
    }
}