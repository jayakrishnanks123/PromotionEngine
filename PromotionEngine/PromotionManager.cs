using Model;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    internal class PromotionManager
    {
        public PromotionManager()
        {
        }

        internal List<Product> ApplyDiscount(List<Product> products)
        {
            return new List<Product>
            {
                new Product{ Name = "A", SalePrice = 50},
                new Product{ Name = "B", SalePrice= 30},
                new Product {Name = "C", SalePrice=20}
            };
        }
    }
}