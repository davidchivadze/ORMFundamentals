using ORMFundamentals.Domain.Models.ViewModels.Order;
using ORMFundamentals.Domain.Repository;
using ORMFundamentals.Domain.Services;
using ORMFundamentals.Infrastructure.Helper;
using System;

namespace ORMFundamentals.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository=orderRepository;
        }
        public AddOrdersViewModel AddOrder(AddOrdersViewModel order)
        {
            try
            {
                var result = _orderRepository.AddOrder(order.AsAddOrdersDatabaseModel()).AsAddOrdersViewModel();
                return result;
            }catch(Exception ex)
            {
                return null;
            }
        }

        public OrderViewModel DeleteOrder(int orderID)
        {
            try
            {
                var result = _orderRepository.DeleteOrder(orderID).AsOrderViewModel();
                return result;
            }catch(Exception ex)
            {
                return null;
            }

    }

        public OrderViewModel GetOrderById(int orderID)
        {
            try
            {
                var getOrder = _orderRepository.GetOrderById(orderID).AsOrderViewModel();
                return getOrder;
            }catch(Exception ex)
            {
                return null;
            }
        }

        public GetOrdersViewModel GetOrders(OrderFilterViewModel filter=null)
        {
            try
            {
                var orders = _orderRepository.GetOrders(filter.ProductID, filter.Month,filter.Year, filter.Status).AsGetOrdersViewModel();
                return orders;
            }catch(Exception ex)
            {
                
                return null;
            }
        }

        public OrderViewModel UpdateOrder(OrderViewModel order)
        {
            try
            {              
                var updateOrder = _orderRepository.UpdateOrder(order.AsUpdateOrderDatabaseModel()).AsOrderViewModel();
                return updateOrder;
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
