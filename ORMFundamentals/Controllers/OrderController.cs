using Microsoft.AspNetCore.Mvc;
using ORMFundamentals.Domain.Models.ViewModels.Order;
using ORMFundamentals.Domain.Services;
using System;

namespace ORMFundamentals.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService= orderService;
        }
        public IActionResult Index(OrderFilterViewModel filter=null)
        {
            var result = _orderService.GetOrders(filter);
            return View(result);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var result = _orderService.GetOrderById(Id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(OrderViewModel model)
        {
            var result = _orderService.UpdateOrder(model);
            return RedirectToAction("Index", "Order");
        }
        public IActionResult Delete(int Id)
        {
            try
            {
                var result = _orderService.DeleteOrder(Id);
                if (result != null)
                {
                    return RedirectToAction("Index", "Order");
                }
                else
                {
                    return StatusCode(503);
                }
            }catch(Exception ex)
            {
                return StatusCode(503);
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddOrdersViewModel model)
        {
            var result=_orderService.AddOrder(model);
            return RedirectToAction("Index", "Order");
        }
    }
}
