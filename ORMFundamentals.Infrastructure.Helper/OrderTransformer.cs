using Domain.EntityModels;
using ORMFundamentals.Domain.Models.ViewModels.Order;
using System;
using System.Linq;

namespace ORMFundamentals.Infrastructure.Helper
{
    public static class OrderTransformer
    {
        public static Order AsAddOrdersDatabaseModel(this AddOrdersViewModel model)
        {
            return new Order()
            {
                Id = model.Id,
                CreatedDate = DateTime.Now,
                ProductId = model.ProductId,
                Status = model.Status,
                UpdatedDate = DateTime.Now,
            };
        }
        public static AddOrdersViewModel AsAddOrdersViewModel(this Order model)
        {
            return new AddOrdersViewModel()
            {
                Id = model.Id,
                ProductId = model.ProductId,
                Status = model.Status,
            };
        }
        public static OrderViewModel AsOrderViewModel(this Order order)
        {
            return new OrderViewModel()
            {
                Id = order.Id,
                CreatedDate = order.CreatedDate,
                ProductId = order.ProductId,
                Status = order.Status,
                UpdatedDate = order.UpdatedDate
            };
        }
        public static GetOrdersViewModel AsGetOrdersViewModel(this IQueryable<Order> orders)
        {
            GetOrdersViewModel model = new GetOrdersViewModel();
            model.Orders = orders.Select(m => new GetOrdersItems()
            {
                CreatedDate = m.CreatedDate,
                ProductId = m.ProductId,
                Id = m.Id,
                Status = m.Status,
                UpdatedDate = m.UpdatedDate,
            }).ToList();
            return model;
        }
        public static Order AsUpdateOrderDatabaseModel(this OrderViewModel model)
        {
            return new Order()
            {
                Id = model.Id,
                ProductId = model.ProductId,
                Status = model.Status,
                UpdatedDate = DateTime.Now,

            };
        }
    }
}
