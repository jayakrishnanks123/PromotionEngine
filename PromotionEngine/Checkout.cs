using Model;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public interface ICheckOut
    {
        List<Product> CheckoutProducts(List<Product> products);
    }
    public class Checkout:ICheckOut
    {
        //ProductManager productManager = new ProductManager();
        //PromotionManager promotionManager = new PromotionManager();
        private readonly IProductManager _productManager;
        private readonly IPromotionManager _promotionManager;

        public Checkout( IProductManager productManager,IPromotionManager promotionManager)
        {
            _productManager = productManager;
            _promotionManager = promotionManager;

        }

        public List<Product> CheckoutProducts(List<Product> products)
        {
            var order = _productManager.CreateOrder(products);
            order = _promotionManager.ApplyDiscount(order);
            return order;
        }
    }
}