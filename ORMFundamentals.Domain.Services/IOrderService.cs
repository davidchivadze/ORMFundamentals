using ORMFundamentals.Domain.Models.ViewModels.Order;
using System;
using System.Linq;

namespace ORMFundamentals.Domain.Services
{
    public interface IOrderService
    {
        GetOrdersViewModel GetOrders();
        OrderViewModel UpdateOrder(OrderViewModel order);
        OrderViewModel DeleteOrder(int orderID);
        OrderViewModel GetOrderById(int orderID);
        AddOrdersViewModel AddOrder(AddOrdersViewModel order);
    }
}
