using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Beverage
    {
        private Decimal cost;
        public string Description { get; set; }

        public Beverage(Decimal cost)
        {
            this.cost = cost;
        }

        public Decimal GetCost()
        {
            return cost;
        }
    }
}
