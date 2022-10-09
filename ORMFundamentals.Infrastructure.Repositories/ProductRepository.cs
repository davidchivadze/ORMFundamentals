using Domain.EntityModels;
using Microsoft.EntityFrameworkCore;
using ORMFundamentals.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMFundamentals.Infrastructure.Repositories
{
    public class ProductRepository :BaseRepository<Product>, IProductRepository
    {
        public Product AddProduct(Product product)
        {
            return this.Add(product);
        }

        public Product DeleteProduct(int productID)
        {
            var deleteProduct = this.Get().Where(m => m.Id == productID).FirstOrDefault();
            this.Database.Remove(deleteProduct);
            this.Database.SaveChanges();
            return deleteProduct;
        }

        public Product GetProductById(int productID)
        {
            return this.Get().Where(m => m.Id == productID).FirstOrDefault();
        }

        public IQueryable<Product> GetProducts()
        {
            return this.Get();    
        }

        public Product UpdateProduct(Product product)
        {
            var updateProduct = this.Get().Where(m => m.Id == product.Id).FirstOrDefault();
            updateProduct.Width = product.Width;
            updateProduct.Height = product.Height;
            updateProduct.Weight = product.Weight;
            updateProduct.Length = product.Length;
            updateProduct.Name = product.Name;
            this.Update(updateProduct);
            return updateProduct;
        }
    }
}
