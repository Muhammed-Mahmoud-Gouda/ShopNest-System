using Microsoft.AspNetCore.Http;
using ShopNest.BLL.Validators;
using System.ComponentModel.DataAnnotations;

namespace ShopNest.BLL.DTOs.Category
{
    public class CategoryCreateDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public IFormFile? Image { get; set; }
    }
}