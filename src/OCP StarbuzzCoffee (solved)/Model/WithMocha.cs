using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class WithMocha : Beverage
    {
        private readonly Beverage beverage;

        public WithMocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal GetCost()
        {
            return beverage.GetCost() + 0.5m;
        }
    }
}
