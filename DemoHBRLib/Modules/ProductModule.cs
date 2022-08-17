using DemoHBRLib.Models;
using DemoHBRLib.Services;
using System.Collections.Generic;

namespace DemoHBRLib.Modules
{
    public class ProductModule
    {
        public List<Product> GetProducts()
        {
            return ProductService.GetProducts();
        }

        public Product GetProductById(int id)
        {
            return ProductService.GetProductById(id);
        }

        public bool CreateProduct(Product product)
        {
            return ProductService.CreateProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return ProductService.DeleteProduct(id);
        }
    }
}
