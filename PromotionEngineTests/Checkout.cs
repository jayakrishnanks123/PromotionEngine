using Model;
using System;
using System.Collections.Generic;

namespace PromotionEngineTests
{
    internal class Checkout
    {
        ProductManager productManager = new ProductManager();
        PromotionManager promoEngine = new PromotionManager();

        public Checkout()
        {
        }

        internal List<Product> CheckoutProducts(List<Product> products)
        {
            var order = productManager.CreateOrder(products);
            order = promoEngine.ApplyDiscount(order);
            return order;
        }
    }
}