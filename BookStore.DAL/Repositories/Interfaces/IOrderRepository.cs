using ShpoNest.Models.Entities;
using ShpoNest.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNest.DAL.Repositories.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IEnumerable<Order>> GetAllWithCustomerAsync();
        Task<Order?> GetByIdWithItemsAsync(int id);
        Task<IEnumerable<Order>> GetByCustomerIdAsync(int customerId);
        Task<IEnumerable<Order>> GetByStatusAsync(OrderStatus status);
    }
}
