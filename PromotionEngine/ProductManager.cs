using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class ProductManager
    {
        public static List<Product> Products { get; set; }
        public ProductManager()
        {
            CreateProducts();
        }
        public void CreateProducts()
        {
            Products = new List<Product>
            { 
                new Product { Name = "A", UnitPrice = 50 },
                new Product { Name = "B", UnitPrice = 30 },
                new Product { Name = "C", UnitPrice = 20 },
                new Product { Name = "D", UnitPrice = 15 }
            };
        }

        public List<Product> CreateOrder(List<Product> products)
        {
            foreach (var item in products)
            {
                item.UnitPrice = Products.First(o => o.Name == item.Name).UnitPrice;
            }
            return products;
        }
    }
}