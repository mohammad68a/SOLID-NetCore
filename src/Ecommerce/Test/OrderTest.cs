using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model;
using NUnit.Framework;

namespace Ecommerce.Test
{
    [TestFixture]
    class OrderTest
    {
        [Test]
        public void EmptyOrder_Return0()
        {
            Order order = new Order();
            Assert.That(order.GetSubtotal(), Is.EqualTo(0));
        }

        [Test]
        public void OrderWith1Product_Return10()
        {
            Order order = new Order();
            order.Add(new Item(10, 1));
            Assert.That(order.GetSubtotal(), Is.EqualTo(10));
        }

        [Test]
        public void OrderWith2Product_Return20()
        {
            Order order = new Order();
            order.Add(new Item(10, 1));
            order.Add(new Item(5, 2));

            Assert.That(order.GetSubtotal(), Is.EqualTo(20));
        }

        [Test]
        public void OrderWithDiscount1234_Return18()
        {
            Order order = new Order();
            order.Add(new Item(10, 1));
            order.Add(new Item(5, 2));

            order.Discount = new Discount(1234, 0.1m, false);
            order.Discount.Apply();

            Assert.That(order.GetTotal(), Is.EqualTo(18));
        }

        [Test]
        public void OrderWithAlabamaTax_Return10_4()
        {
            Order order = new Order();
            order.Add(new Item(10, 1));

            order.Tax = new UsaTax() { State = "Alabama", Percentage = 4 };

            Assert.That(order.GetTotal(), Is.EqualTo(10.4m));
        }

    }
}
