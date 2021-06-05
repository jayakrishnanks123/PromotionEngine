using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Promotion : IPromotion
    {
        public IList<string> ProductNames { get; set; }
        public bool IsCombo { get; set; }
        public int SalePrice { get; set; }
        public int ProductCount { get; set; }
    }

}
