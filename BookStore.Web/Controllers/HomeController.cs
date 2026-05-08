using Microsoft.AspNetCore.Mvc;
using ShopNest.BLL.Services.Interfaces;

namespace ShopNest.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public HomeController(
            IProductService productService,
            ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var allProducts = await _productService.GetAllWithCategoryAsync();
            var categories = await _categoryService.GetAllAsync();

            ViewBag.FeaturedBooks = allProducts
                .Where(p => p.IsActive)
                .Take(4)
                .ToList();

            ViewBag.NewArrivals = allProducts
                .Where(p => p.IsActive)
                .OrderByDescending(p => p.Id)
                .Take(4)
                .ToList();

            ViewBag.Categories = categories
                .Where(c => c.IsActive)
                .ToList();

            ViewBag.TotalBooks = allProducts.Count();
            ViewBag.TotalCustomers = 12000;

            return View();
        }
    }
}