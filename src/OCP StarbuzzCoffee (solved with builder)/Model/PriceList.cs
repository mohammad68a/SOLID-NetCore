using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PriceList
    {
        public decimal GetExpresso()
        {
            return 5m;
        }
        public decimal GetMocha()
        {
            return 0.5m;
        }
        public decimal GetSteamedMilk()
        {
            return 1m;
        }
    }
}
