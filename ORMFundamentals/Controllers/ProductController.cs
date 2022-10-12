using Microsoft.AspNetCore.Mvc;
using ORMFundamentals.Domain.Models.ViewModels.Product;
using ORMFundamentals.Domain.Services;
using System;

namespace ORMFundamentals.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;   
        }
        public IActionResult Index()
        {
            var result = _productService.GetProducts();
            return View(result);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var result = _productService.GetProductById(Id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel model)
        {
            var result = _productService.UpdateProduct(model);
            return RedirectToAction("Index", "Product");
        }
        public IActionResult Delete(int Id)
        {
            try
            {
                var result = _productService.DeleteProduct(Id);
                if (result != null)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    return StatusCode(503);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(503);
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddProductViewModel model)
        {
            var result = _productService.AddProduct(model);
            return RedirectToAction("Index", "Product");
        }
    }
}
