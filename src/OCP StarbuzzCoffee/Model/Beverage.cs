using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public abstract class Beverage
    {
        public string Description { get; set; }
        public abstract Decimal GetCost();
    }
}
