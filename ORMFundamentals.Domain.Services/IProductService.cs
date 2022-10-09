using ORMFundamentals.Domain.Models.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORMFundamentals.Domain.Services
{
    public interface IProductService
    {
        GetProductsViewModel GetProducts();
        AddProductViewModel AddProduct(AddProductViewModel product);
        ProductViewModel UpdateProduct(ProductViewModel product);
        ProductViewModel DeleteProduct(int productID);
        ProductViewModel GetProductById(int productID);
    }
}
