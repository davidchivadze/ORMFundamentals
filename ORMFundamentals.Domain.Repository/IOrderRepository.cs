using Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMFundamentals.Domain.Repository
{
    public interface IOrderRepository:IBaseRepository<Order>
    {
        IQueryable<Order> GetOrders();
        Order UpdateOrder (Order order);
        Order DeleteOrder (int orderID);
        Order GetOrderById (int orderID);
        Order AddOrder(Order order);
    }
}
