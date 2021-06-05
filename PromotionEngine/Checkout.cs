using Model;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class Checkout
    {
        ProductManager productManager = new ProductManager();
        PromotionManager promotionManager = new PromotionManager();

        public Checkout()
        {
        }

        public List<Product> CheckoutProducts(List<Product> products)
        {
            var order = productManager.CreateOrder(products);
            order = promotionManager.ApplyDiscount(order);
            return order;
        }
    }
}