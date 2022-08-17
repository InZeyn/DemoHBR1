using DemoHBRLib.Models;
using System.Collections.Generic;

namespace DemoHBRLib.Services
{
    internal class ProductService
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            for(int i = 10; i > 0; i--)
            {
                Product product = new Product
                {
                    ID = i,
                    Description = i.ToString(),
                    Name = i.ToString()
                };
                products.Add(product);
            }
            return products;
        }

        public static Product GetProductById(int id)
        {
            return new Product();
        }

        public static bool CreateProduct(Product product)
        {
            return true;
        }

        public static bool DeleteProduct(int id)
        {
            return true;
        }
    }
}
