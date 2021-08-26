using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Expresso : Beverage
    {
        public override Decimal GetCost()
        {
            return 5m;
        }
    }
}
