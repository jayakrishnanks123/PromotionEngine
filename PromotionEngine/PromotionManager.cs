using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class PromotionManager
    {
        public List<Promotion> Promotions { get; set; }

        public PromotionManager()
        {
            Promotions = new List<Promotion>()
            {
                new Promotion { ProductNames = new List<string> { "A" }, Count = 3, SalePrice = 130 },
                new Promotion { ProductNames = new List<string> { "B" }, Count = 2, SalePrice= 45 },
                new Promotion { ProductNames = new List<string> { "C", "D" }, IsCombo= true, SalePrice= 30,Count=2 }
            };
        }

        public List<Product> ApplyDiscount(List<Product> orders)
        {
            var products = orders
                .GroupBy(o => o.Name)
                .Select(g => new { Product = g.Key, Quantity = g.Sum(q => q.Quantity) })
                .ToDictionary(x => x.Product, y => y.Quantity);

            ApplySingleDiscount(orders, products);
            ApplyMultipleDiscount(orders,products);
            UpdateSalePrice(orders, products);
            return orders;
        }
        private void ApplyMultipleDiscount(IList<Product> orders, Dictionary<string, int> products)
        {
            foreach (var promotion in Promotions.Where(x => x.IsCombo))
            {
                var names = promotion.ProductNames;

                var eligibleProducts = products.Where(x => names.Contains(x.Key));
                if (eligibleProducts.Count() < promotion.Count) return;

                var productCount = eligibleProducts.Min(x => x.Value);

                if (productCount > 0)
                {
                    foreach (var name in names)
                    {
                        if (products.ContainsKey(name))
                            products[name] = products[name] - productCount;
                    }
                    var promoOrder = orders.FirstOrDefault(x => x.Name == names[names.Count - 1]);
                    if (promoOrder != null)
                        promoOrder.SalePrice+= (productCount * promotion.SalePrice);
                }

            }
        }
        private void ApplySingleDiscount(IList<Product> orders, Dictionary<string, int> products)
        {
            foreach (var promotion in Promotions.Where(x => !x.IsCombo))
            {
                var order = orders.FirstOrDefault(x => promotion.ProductNames.Contains(x.Name));
                if (order != null)
                {
                    var noOfProducts = promotion.Count;
                    order.SalePrice= (order.Quantity / noOfProducts) * promotion.SalePrice;
                    products[order.Name] = (order.Quantity % noOfProducts);
                }
            }
        }
        private void UpdateSalePrice(IList<Product> orders, Dictionary<string, int> products)
        {
            foreach (var order in orders)
            {
                int unitPrice = products[order.Name] * order.UnitPrice;
                order.SalePrice+= unitPrice;
            }
        }
    }
}