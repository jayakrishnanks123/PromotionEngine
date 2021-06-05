using Model;
using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IProductManager
    {
        List<Product> CreateOrder(List<Product> products);
    }
}