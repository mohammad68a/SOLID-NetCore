using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class WithSteamedMilk : Beverage
    {
        private readonly Beverage beverage;

        public WithSteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal GetCost()
        {
            return beverage.GetCost() + 1;
        }
    }
}
