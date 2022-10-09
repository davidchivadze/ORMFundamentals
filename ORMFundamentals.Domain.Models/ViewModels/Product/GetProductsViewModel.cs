using System;
using System.Collections.Generic;
using System.Text;

namespace ORMFundamentals.Domain.Models.ViewModels.Product
{
    public class GetProductsViewModel
    {
        public List<GetProductsItem> Products { get; set; }
    }
    public class GetProductsItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
    }
}
