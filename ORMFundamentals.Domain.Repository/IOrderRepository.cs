using Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMFundamentals.Domain.Repository
{
    public interface IOrderRepository:IBaseRepository<Order>
    {
        IEnumerable<Order> GetOrders(int? productID, int? month, int? year, int? status);
        Order UpdateOrder (Order order);
        Order DeleteOrder (int orderID);
        Order GetOrderById (int orderID);
        Order AddOrder(Order order);
    }
}
