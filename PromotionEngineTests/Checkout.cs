using Model;
using System;
using System.Collections.Generic;

namespace PromotionEngineTests
{
    internal class Checkout
    {
        public Checkout()
        {
        }

        internal List<Product> CheckoutProducts(List<Product> orders)
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