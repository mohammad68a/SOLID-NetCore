using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model;
using NUnit.Framework;

namespace Ecommerce.Test
{
    [TestFixture]
    class UsaTaxTest
    {
        [Test]
        public void AlaskaTax_Get0()
        {
            UsaTax tax = new UsaTax() { State = "Alaska", Percentage = 0};
            Assert.That(tax.GetAmount(10), Is.EqualTo(0));
        }

        [Test]
        public void AlabamaTax_Get40()
        {
            UsaTax tax = new UsaTax() { State = "Alaska", Percentage = 4 };
            Assert.That(tax.GetAmount(1000), Is.EqualTo(40));
        }
    }
}
