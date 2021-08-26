using Ecommerce.Model;
using NUnit.Framework;

namespace Ecommerce.Test
{
    [TestFixture]
    class DiscountTest
    {
        [Test]
        public void UnusedDiscount1234_Return10p()
        {
            // arrange
            Discount discount = new Discount(1234, 0.1m, false);

            // act
            discount.Apply();

            // assert
            Assert.That(discount.GetAmount(10), Is.EqualTo(1));
            Assert.That(discount.Used, Is.True);
        }
        [Test]
        public void UsedDiscount1234_Return0p()
        {
            // arrange
            Discount discount = new Discount(1234, 0.1m, true);

            // act
            discount.Apply();

            // assert
            Assert.That(discount.GetAmount(10), Is.EqualTo(0));
            Assert.That(discount.Used, Is.True);
        }

    }
}
