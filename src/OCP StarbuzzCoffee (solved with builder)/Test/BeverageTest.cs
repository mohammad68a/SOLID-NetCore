using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Model;

namespace Test
{
    [TestFixture]
    public class BeverageTest
    {
        [Test]
        public void Expresso()
        {
            // arrange
            BeverageBuilder beverageBuilder = new BeverageBuilder(new PriceList());
            Beverage beverage = beverageBuilder
                                    .CreateExpresso()
                                    .Build();

            // act
            decimal cost = beverage.GetCost();

            // assert
            Assert.That(5, Is.EqualTo(cost));
        }

        [Test]
        public void ExpressoWithMocha()
        {
            // arrange
            BeverageBuilder beverageBuilder = new BeverageBuilder(new PriceList());
            Beverage beverage = beverageBuilder
                                    .CreateExpresso()
                                    .WithMocha()
                                    .Build();

            // act
            decimal cost = beverage.GetCost();

            // assert
            Assert.That(5.5, Is.EqualTo(cost));
        }

        [Test]
        public void ExpressoWithSteamedMilkAndMocha()
        {
            // arrange
            BeverageBuilder beverageBuilder = new BeverageBuilder(new PriceList());
            Beverage beverage = beverageBuilder
                                    .CreateExpresso()
                                    .WithMocha()
                                    .WithSteamedMilk()
                                    .Build();

            // act
            decimal cost = beverage.GetCost();

            // assert
            Assert.That(6.5, Is.EqualTo(cost));
        }
    }
}
