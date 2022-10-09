using Domain.EntityModels;
using ORMFundamentals.Domain.Models.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMFundamentals.Infrastructure.Helper
{
    public static class ProductTransformer
    {
        public static Product AsAddProductsDatabaseModel(this AddProductViewModel model)
        {
            return new Product()
            {
                Length = model.Length,
                Height = model.Height,
                Name = model.Name,
                Width = model.Width,
                Weight = model.Weight
            };
        }
        public static AddProductViewModel AsAddProductsViewModel(this Product model)
        {
            return new AddProductViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                Height = model.Height,
                Weight = model.Weight,
                Length = model.Length,
                Width = model.Width
            };
        }
        public static ProductViewModel AsProductViewModel(this Product Product)
        {
            return new ProductViewModel()
            {
                Id = Product.Id,
                Height = Product.Height,
                Length = Product.Length,
                Name = Product.Name,
                Weight = Product.Weight,
                Width = Product.Width
            };
        }
        public static GetProductsViewModel AsGetProductsViewModel(this IQueryable<Product> Products)
        {
            GetProductsViewModel model = new GetProductsViewModel();
            model.Products = Products.Select(m => new GetProductsItem()
            {
                Id = m.Id,
                Height = m.Height,
                Length = m.Length,
                Width = m.Width,
                Weight = m.Weight,
                Name = m.Name
            }).ToList();
            return model;
        }
        public static Product AsUpdateProductDatabaseModel(this ProductViewModel model)
        {
            return new Product()
            {
                Id = model.Id,
                Name = model.Name,
                Height = model.Height,
                Weight = model.Weight,
                Length = model.Length,
                Width = model.Width

            };
        }
    }
}
