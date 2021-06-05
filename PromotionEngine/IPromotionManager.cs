using Model;
using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IPromotionManager
    {
        List<Product> ApplyDiscount(List<Product> orders);
    }
}