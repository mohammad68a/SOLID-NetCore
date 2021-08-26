using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model;
using Ecommerce.Repositories;
using Ecommerce.Services;
using Moq;
using NUnit.Framework;

namespace Ecommerce.Test
{
    [TestFixture]
    class OrderProcessorServiceTest
    {
        [Test]
        public void EmptyOrder_Return0()
        {
            // arrange
            Order order = new Order();

            Mock<IDiscountService> discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount(0)).Returns(new Discount(0));

            Mock<ITaxRepository> taxRepository = new Mock<ITaxRepository>();
            taxRepository.Setup(x => x.GetByLocation(It.IsAny<string>(), It.IsAny<string>())).Returns(new NullTax());

            Mock<IOrderRepository> orderRepository = new Mock<IOrderRepository>();
            orderRepository.Setup(x => x.Save(order));
            IOrderProcessorService orderProcessorService = new OrderProcessorService(discountService.Object, taxRepository.Object, orderRepository.Object);
            
            // act
            decimal total = orderProcessorService.Process(order);

            // assert
            Assert.That(total, Is.EqualTo(0));

            orderRepository.VerifyAll();
        }

        [Test]
        public void OrderDiscount1234_Return9()
        {
            // arrange
            Mock<IDiscountService> discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount(1234)).Returns(new Discount(1234, 0.1m, false));
            discountService.Setup(x => x.ApplyDiscount(1234));

            Mock<ITaxRepository> taxRepository = new Mock<ITaxRepository>();
            taxRepository.Setup(x => x.GetByLocation(It.IsAny<string>(), It.IsAny<string>())).Returns(new NullTax());

            Mock<IOrderRepository> orderRepository = new Mock<IOrderRepository>();

            IOrderProcessorService orderProcessorService = new OrderProcessorService(discountService.Object, taxRepository.Object, orderRepository.Object);
            Order order = new Order();
            order.Add(new Item(10, 1));

            order.Discount = new Discount(1234);

            // act
            decimal total = orderProcessorService.Process(order);

            // assert
            Assert.That(total, Is.EqualTo(9));
            discountService.VerifyAll();
        }

        [Test]
        public void OrderTaxAlabama_Return10_4()
        {
            // arrange
            Mock<IDiscountService> discountService = new Mock<IDiscountService>();
            discountService.Setup(x => x.GetDiscount(0)).Returns(new Discount(0));

            Mock<ITaxRepository> taxRepository = new Mock<ITaxRepository>();
            taxRepository.Setup(x => x.GetByLocation("USA", "Alabama")).Returns(new UsaTax() { Percentage = 4 });

            Mock<IOrderRepository> orderRepository = new Mock<IOrderRepository>();

            IOrderProcessorService orderProcessorService = new OrderProcessorService(discountService.Object, taxRepository.Object, orderRepository.Object);
            Order order = new Order();
            order.Country = "USA";
            order.State = "Alabama";
            order.Add(new Item(10, 1));

            // act
            decimal total = orderProcessorService.Process(order);

            // assert
            Assert.That(total, Is.EqualTo(10.4));
        }


    }
}
