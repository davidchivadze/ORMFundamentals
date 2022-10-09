using Domain.EntityModels;
using ORMFundamentals.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMFundamentals.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepository<Order>,IOrderRepository
    {
        public Order AddOrder(Order order)
        {
            return this.Add(order);
        }

        public Order DeleteOrder(int orderID)
        {
            var order = this.Get().Where(m => m.Id == orderID).FirstOrDefault();
            if (order != null)
            {
                this.Database.Remove(order);
                this.Database.SaveChanges();
                return order;
            }
            else
            {
                throw new KeyNotFoundException(String.Format("Order Not Found With ID:{0}", orderID.ToString()));
            }
        }

        public Order GetOrderById(int orderID)
        {
           return this.Get().Where(m => m.Id == orderID).FirstOrDefault();
        }

        public IQueryable<Order> GetOrders()
        {
            return this.Get();
        }

        public Order UpdateOrder(Order order)
        {
            var updateOrder=this.Get().Where(m => m.Id == order.Id).FirstOrDefault();
            updateOrder.UpdatedDate = order.UpdatedDate;
            updateOrder.CreatedDate = order.CreatedDate;
            updateOrder.ProductId = order.ProductId;
            updateOrder.Status = order.Status;
            this.Update(updateOrder);
            return updateOrder;
        }
    }
}
