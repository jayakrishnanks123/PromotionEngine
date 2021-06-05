using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Promotion
    {
        public IList<string> ProductNames { get; set; }
        public bool IsCombo { get; set; }
        public int Discount { get; set; }
        public int Count { get; set; }
    }

}
