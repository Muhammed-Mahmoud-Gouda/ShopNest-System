using Microsoft.AspNetCore.Http;
using ShopNest.BLL.Validators;
using ShpoNest.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.BLL.DTOs.Product
{
    public class ProductCreateDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(200, ErrorMessage = "Name cannot exceed 200 characters")]
        public string Name { get; set; }

        [StringLength(2000, ErrorMessage = "Description cannot exceed 2000 characters")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [PriceRange(0.01, 999999)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        [NonNegativeStock]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        // Book Specs
        [StringLength(200, ErrorMessage = "Author cannot exceed 200 characters")]
        public string? Author { get; set; }

        [StringLength(200, ErrorMessage = "Publisher cannot exceed 200 characters")]
        public string? Publisher { get; set; }

        [StringLength(20, ErrorMessage = "ISBN cannot exceed 20 characters")]
        public string? ISBN { get; set; }

        [YearRange]
        public int? PublicationYear { get; set; }

        [Range(1, 10000, ErrorMessage = "Pages must be between 1 and 10000")]
        public int? Pages { get; set; }

        [StringLength(50, ErrorMessage = "Language cannot exceed 50 characters")]
        public string? Language { get; set; }

        [StringLength(50, ErrorMessage = "Edition cannot exceed 50 characters")]
        public string? Edition { get; set; }

        public BookFormat? Format { get; set; }

        [AllowedExtensions(new[] { ".jpg", ".jpeg", ".png", ".webp" })]
        [MaxFileSize(5)]
        public List<IFormFile>? Images { get; set; }
    }
}