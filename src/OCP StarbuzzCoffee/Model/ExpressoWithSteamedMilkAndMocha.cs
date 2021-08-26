using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class EspressoWithSteamedMilkAndMocha : Beverage
    {
        public override decimal GetCost()
        {
            return 6.5m;
        }
    }
}
