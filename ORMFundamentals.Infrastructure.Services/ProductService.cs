using ORMFundamentals.Domain.Models.ViewModels.Product;
using ORMFundamentals.Domain.Repository;
using ORMFundamentals.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using ORMFundamentals.Infrastructure.Helper;
namespace ORMFundamentals.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public AddProductViewModel AddProduct(AddProductViewModel product)
        {
            try
            {
                var result = _productRepository.AddProduct(product.AsAddProductsDatabaseModel()).AsAddProductsViewModel();
                return result;
            }catch(Exception ex)
            {
                return null;
            }
    
        }

        public ProductViewModel DeleteProduct(int productID)
        {
            try
            {
                var result = _productRepository.DeleteProduct(productID).AsProductViewModel();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ProductViewModel GetProductById(int productID)
        {
            try
            {
                var result = _productRepository.GetProductById(productID).AsProductViewModel();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public GetProductsViewModel GetProducts()
        {
            try
            {
                var result = _productRepository.GetProducts().AsGetProductsViewModel();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public ProductViewModel UpdateProduct(ProductViewModel product)
        {
            try
            {
                var result = _productRepository.Update(product.AsUpdateProductDatabaseModel()).AsProductViewModel();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
