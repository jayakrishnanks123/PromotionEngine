using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using PromotionEngine;
using System.Collections.Generic;

namespace PromotionEngineTests
{
    [TestClass]
    public class Tests
    {
        ServiceProvider provider;
        ICheckOut checkOut;
        [TestInitialize]
        public void Init()
        {
            provider = new ServiceCollection()
               .AddScoped<IPromotionManager, PromotionManager>()
               .AddScoped<IProductManager, ProductManager>()
               .AddScoped<ICheckOut, Checkout>()
               .BuildServiceProvider();
            checkOut = provider.GetService<ICheckOut>();
        }
        [TestMethod]
        public void Test1()
        {
            var products = new List<Product>
            {
                new Product{ Name = "A", Quantity = 1},
                new Product{ Name = "B", Quantity = 1},
                new Product {Name = "C", Quantity=1}
            };

            var response = checkOut.CheckoutProducts(products);

            Assert.AreEqual(50, response[0].SalePrice);
            Assert.AreEqual(30, response[1].SalePrice);
            Assert.AreEqual(20, response[2].SalePrice);
        }
        [TestMethod]
        public void Test2()
        {
            var products = new List<Product>
           {
               new Product{ Name = "A", Quantity = 5},
               new Product{ Name = "B", Quantity = 5},
               new Product {Name = "C", Quantity=1}
           };
            var response = checkOut.CheckoutProducts(products);

            Assert.AreEqual(230, response[0].SalePrice);
            Assert.AreEqual(120, response[1].SalePrice);
            Assert.AreEqual(20, response[2].SalePrice);
        }
        [TestMethod]
        public void Test3()
        {
            var products = new List<Product>
           {
               new Product{ Name = "A", Quantity = 3},
               new Product{ Name = "B", Quantity = 5},
               new Product {Name = "C", Quantity=1},
               new Product {Name = "D", Quantity=1}
           };
            var response = checkOut.CheckoutProducts(products);

            Assert.AreEqual(130, response[0].SalePrice);
            Assert.AreEqual(120, response[1].SalePrice);
            Assert.AreEqual(0, response[2].SalePrice);
            Assert.AreEqual(30, response[3].SalePrice);
        }
    }
}
