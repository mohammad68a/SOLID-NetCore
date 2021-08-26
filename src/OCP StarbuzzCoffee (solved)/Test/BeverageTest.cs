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
            Beverage beverage = new Expresso();

            // act
            decimal cost = beverage.GetCost();

            // assert
            Assert.That(5, Is.EqualTo(cost));
        }

        [Test]
        public void ExpressoWithMocha()
        {
            // arrange
            Beverage beverage = new WithMocha(new Expresso());

            // act
            decimal cost = beverage.GetCost();

            // assert
            Assert.That(5.5, Is.EqualTo(cost));
        }

        [Test]
        public void ExpressoWithSteamedMilkAndMocha()
        {
            // arrange
            Beverage beverage = new WithSteamedMilk(new WithMocha(new Expresso()));

            // act
            decimal cost = beverage.GetCost();

            // assert
            Assert.That(6.5, Is.EqualTo(cost));
        }
    }
}
