using Microsoft.Extensions.DependencyInjection;
using ShopNest.BLL.Services.Implementations;
using ShopNest.BLL.Services.Interfaces;
using ShopNest.DAL.Repositories.Implementations;
using ShopNest.DAL.Repositories.Interfaces;

namespace BookStore.BLL.Common
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services)
        {
            //Repositories
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //services
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerAddressService, CustomerAddressService>();
            services.AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}