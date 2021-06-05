using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using PromotionEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Tests
{
    [TestClass()]
    public class ProductManagerTests
    {
        [TestMethod()]
        public void CreateOrderTest()
        {
            ProductManager manager = new ProductManager();
            var products = new List<Product>
            {
                new Product{ Name = "A", Quantity = 1},
                new Product{ Name = "B", Quantity = 1},
                new Product {Name = "C", Quantity=1}
            };
            var response=manager.CreateOrder(products);
            Assert.IsTrue(response.TrueForAll(o => o.UnitPrice > 0));

        }
    }
}