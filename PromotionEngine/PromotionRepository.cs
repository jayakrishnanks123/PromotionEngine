using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IPromotionRepository { List<IPromotion> GetPromotions(); }
    public class PromotionRepository: IPromotionRepository
    {
        public List<IPromotion> GetPromotions()
        {
            //get from db for extensibility
            return new List<IPromotion>()
            {
                new Promotion { ProductNames = new List<string> { "A" }, ProductCount = 3, SalePrice = 130 },
                new Promotion { ProductNames = new List<string> { "B" }, ProductCount = 2, SalePrice= 45 },
                new Promotion { ProductNames = new List<string> { "C", "D" }, IsCombo= true, SalePrice= 30,ProductCount=2 }
            };
        }

    }
}
