using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class BeverageBuilder
    {
        private readonly PriceList priceList;
        private Beverage beverage;
        private int test;

        public int Test
        {
            get { return test; }
            set { test = value; }
        }


        public BeverageBuilder(PriceList priceList)
        {
            this.priceList = priceList;
        }

        public BeverageBuilder CreateExpresso()
        {
            beverage = new Beverage(priceList.GetExpresso());
            return this;
        }
        public BeverageBuilder WithMocha()
        {
            beverage = new Beverage(beverage.GetCost() + priceList.GetMocha());
            return this;
        }
        public BeverageBuilder WithSteamedMilk()
        {
            beverage = new Beverage(beverage.GetCost() + priceList.GetSteamedMilk());
            return this;
        }
        public Beverage Build()
        {
            return beverage;
        }
    }
}
