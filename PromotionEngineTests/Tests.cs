using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Collections.Generic;

namespace PromotionEngineTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1()
        {
            var products = new List<Product>
            {
                new Product{ Name = "A", Quantity = 1},
                new Product{ Name = "B", Quantity = 1},
                new Product {Name = "C", Quantity=1}
            };
            var response= new Checkout().CheckoutProducts(products);

            Assert.AreEqual(response[0].SalePrice, 50);
            Assert.AreEqual(response[1].SalePrice, 30);
            Assert.AreEqual(response[2].SalePrice, 20);
        }

    }
}
