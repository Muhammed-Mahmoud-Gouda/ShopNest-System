namespace ShopNest.DAL.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IProductImageRepository ProductImages { get; }
        ICategoryRepository Categories { get; }
        ICustomerRepository Customers { get; }
        ICustomerAddressRepository CustomerAddresses { get; }
        IOrderRepository Orders { get; }
        Task<int> SaveChangesAsync();
    }

}
