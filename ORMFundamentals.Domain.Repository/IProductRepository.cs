using Domain.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMFundamentals.Domain.Repository
{
    public interface IProductRepository:IBaseRepository<Product>
    {
         IQueryable<Product> GetProducts();
        Product AddProduct(Product product);
        Product UpdateProduct(Product product);
        Product DeleteProduct(int productID);
        Product GetProductById(int productID);  
    }
}
