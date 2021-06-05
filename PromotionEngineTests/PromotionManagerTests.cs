using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using PromotionEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Tests
{
    [TestClass()]
    public class PromotionManagerTests
    {
        [TestMethod()]
        public void ApplySingleDiscountTest()
        {
            PromotionManager manager = new PromotionManager();
            var orders = new List<Product>
            {
                new Product{ Name = "A", Quantity = 3,UnitPrice=50}
            };
            var response=manager.ApplyDiscount(orders);
            Assert.AreEqual(130, response.First().SalePrice);
        }
        [TestMethod()]
        public void ApplyMultipleDiscountTest()
        {
            PromotionManager manager = new PromotionManager();
            var orders = new List<Product>
            {
                new Product{ Name = "C", Quantity = 1,UnitPrice=20},
                new Product{ Name = "D", Quantity = 1,UnitPrice=15}
            };
            var response = manager.ApplyDiscount(orders);
            Assert.AreEqual(0, response[0].SalePrice);
            Assert.AreEqual(30, response[1].SalePrice);
        }
    }
}