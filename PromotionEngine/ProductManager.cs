using Model;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    internal class ProductManager
    {
        internal List<Product> CreateOrder(List<Product> products)
        {
            return new List<Product>
            {
                new Product{ Name = "A"},
                new Product{ Name = "B"},
                new Product {Name = "C" } ,
            };
        }
    }
}