using ShopNest.BLL.Validators;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.Web.ViewModels.Customer
{
    public class CustomerEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(100, ErrorMessage = "First name cannot exceed 100 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(100, ErrorMessage = "Last name cannot exceed 100 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [EgyptianPhone]
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }
}