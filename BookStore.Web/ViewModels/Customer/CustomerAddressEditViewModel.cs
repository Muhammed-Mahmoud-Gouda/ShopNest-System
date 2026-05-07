using System.ComponentModel.DataAnnotations;

namespace ShopNest.Web.ViewModels.Customer
{
    public class CustomerAddressEditViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [StringLength(50, ErrorMessage = "Label cannot exceed 50 characters")]
        [Display(Name = "Label")]
        public string? Label { get; set; }

        [Required(ErrorMessage = "Street is required")]
        [StringLength(300, ErrorMessage = "Street cannot exceed 300 characters")]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(100, ErrorMessage = "City cannot exceed 100 characters")]
        [Display(Name = "City")]
        public string City { get; set; }

        [StringLength(20, ErrorMessage = "Postal code cannot exceed 20 characters")]
        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }

        [Display(Name = "Set as Default")]
        public bool IsDefault { get; set; }
    }
}