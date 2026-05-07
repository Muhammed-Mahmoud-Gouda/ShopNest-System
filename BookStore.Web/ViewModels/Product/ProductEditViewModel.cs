using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopNest.BLL.DTOs.Product;
using ShopNest.BLL.Validators;
using ShpoNest.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.Web.ViewModels.Product
{
    public class ProductEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(200, ErrorMessage = "Name cannot exceed 200 characters")]
        [Display(Name = "Book Title")]
        public string Name { get; set; }

        [StringLength(2000, ErrorMessage = "Description cannot exceed 2000 characters")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [PriceRange(0.01, 999999)]
        [Display(Name = "Price (EGP)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        [NonNegativeStock]
        [Display(Name = "Stock")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

       
        [StringLength(200, ErrorMessage = "Author cannot exceed 200 characters")]
        [Display(Name = "Author")]
        public string? Author { get; set; }

        [StringLength(200, ErrorMessage = "Publisher cannot exceed 200 characters")]
        [Display(Name = "Publisher")]
        public string? Publisher { get; set; }

        [StringLength(20, ErrorMessage = "ISBN cannot exceed 20 characters")]
        [Display(Name = "ISBN")]
        public string? ISBN { get; set; }

        [YearRange]
        [Display(Name = "Publication Year")]
        public int? PublicationYear { get; set; }

        [Range(1, 10000, ErrorMessage = "Pages must be between 1 and 10000")]
        [Display(Name = "Pages")]
        public int? Pages { get; set; }

        [StringLength(50, ErrorMessage = "Language cannot exceed 50 characters")]
        [Display(Name = "Language")]
        public string? Language { get; set; }

        [StringLength(50, ErrorMessage = "Edition cannot exceed 50 characters")]
        [Display(Name = "Edition")]
        public string? Edition { get; set; }

        [Display(Name = "Format")]
        public BookFormat? Format { get; set; }

       
        [AllowedExtensions(new[] { ".jpg", ".jpeg", ".png", ".webp" })]
        [MaxFileSize(5)]
        [Display(Name = "New Images")]
        public List<IFormFile>? NewImages { get; set; }

        public List<ProductImageResultDto> ExistingImages { get; set; } = new();
        public List<int>? RemovedImageIds { get; set; }

       
        public SelectList? Categories { get; set; }
        public SelectList? Formats { get; set; }
    }
}