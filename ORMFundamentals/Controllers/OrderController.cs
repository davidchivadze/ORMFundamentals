using Microsoft.AspNetCore.Mvc;
using ORMFundamentals.Domain.Services;

namespace ORMFundamentals.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService= orderService;
        }
        public IActionResult Index()
        {
            var result = _orderService.GetOrders();
            return View(result);
        }
    }
}
