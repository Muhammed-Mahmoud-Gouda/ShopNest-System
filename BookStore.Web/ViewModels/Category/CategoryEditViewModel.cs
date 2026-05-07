using Microsoft.AspNetCore.Http;
using ShopNest.BLL.Validators;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.Web.ViewModels.Category
{
    public class CategoryEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Current Image")]
        public string? ExistingImagePath { get; set; }

        [AllowedExtensions(new[] { ".jpg", ".jpeg", ".png", ".webp" })]
        [MaxFileSize(5)]
        [Display(Name = "New Image")]
        public IFormFile? Image { get; set; }

        public bool IsActive { get; set; }
    }
}