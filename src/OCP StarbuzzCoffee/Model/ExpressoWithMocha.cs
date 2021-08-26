using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class EspressoWithMocha : Beverage
    {
        public override decimal GetCost()
        {
            return 5.5m;
        }
    }
}
