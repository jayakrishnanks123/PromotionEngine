using System.Collections.Generic;

namespace Model
{
    public interface IPromotion
    {
        int ProductCount { get; set; }
        bool IsCombo { get; set; }
        IList<string> ProductNames { get; set; }
        int SalePrice { get; set; }
    }
}