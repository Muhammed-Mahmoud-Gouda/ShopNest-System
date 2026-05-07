using Microsoft.AspNetCore.Http;
using ShopNest.BLL.Validators;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.Web.ViewModels.Category
{
    public class CategoryCreateViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [AllowedExtensions(new[] { ".jpg", ".jpeg", ".png", ".webp" })]
        [MaxFileSize(5)]
        [Display(Name = "Category Image")]
        public IFormFile? Image { get; set; }
    }
}