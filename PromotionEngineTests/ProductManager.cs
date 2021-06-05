using Model;
using System;
using System.Collections.Generic;

namespace PromotionEngineTests
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