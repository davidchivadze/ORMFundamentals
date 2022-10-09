using Microsoft.AspNetCore.Mvc;

namespace ORMFundamentals.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
