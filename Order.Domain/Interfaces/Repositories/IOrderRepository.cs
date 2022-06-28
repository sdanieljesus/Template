using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task CreateAsync(OrderModel order);
        Task CreateItemAsync(OrderItemModel item);
        Task UpdateAsync(OrderModel order);
        Task UpdateItemAsync(OrderItemModel idem);
        Task DeleteAsync(string orderId);

        Task DeleteItemAsync(string itemId);
        Task<OrderModel> GetByIdAsync(string orderId);
        Task<List<OrderModel>> ListbyFilterAsync(string orderId = null, string clientId = null, string userId = null);
        Task<List<OrderItemModel>> ListItemsByOrderIdAsync(string orderId);
    }
}