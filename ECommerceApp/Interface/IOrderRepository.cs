using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApp.Models;

namespace ECommerceApp.Interface
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Customer>> GetCustomers();

        Task<IEnumerable<Order>> GetOrders();

        Task<OrderViewModel> GetOrder(int? OrderId);

        Task<int> AddCustomer(Customer cust);

        Task<int> AddOrder(Order order);

        Task<int> DeleteOrder(int? OrderId);

        Task UpdateOrder(Order order);
    }
}
