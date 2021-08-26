using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OCP.Filter.Model;

namespace OCP.Filter.Test
{
    [TestFixture]
    class FilterTest
    {
        [Test]
        public void filterByBlue_return_2()
        {
            // arrange
            ProductFilter filter = new ProductFilter();
            IList<Product> products = BuildProducts();

            // act
            var result = filter.ByColor(products, ProductColor.Blue);

            // assert
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Has.All.Matches<Product>(x => x.Color == ProductColor.Blue));
        }

        [Test]
        public void filterBySmall_return_2()
        {
            // arrange
            ProductFilter filter = new ProductFilter();
            IList<Product> products = BuildProducts();

            // act
            var result = filter.BySize(products,  ProductSize.Small);

            // assert
            Assert.That(result.Count(), Is.EqualTo(2));
            Assert.That(result, Has.All.Matches<Product>(x => x.Size == ProductSize.Small));
        }

        [Test]
        public void filterByBlueAndSmall_return_1()
        {
            // arrange
            ProductFilter filter = new ProductFilter();
            IList<Product> products = BuildProducts();

            // act
            var result = filter.ByColorAndSize(products, ProductColor.Blue, ProductSize.Small);

            // assert
            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result, Has.All.Matches<Product>(x => x.Size == ProductSize.Small));
        }

        private IList<Product> BuildProducts()
        {
            return new List<Product> { 
                new Product(ProductColor.Blue, ProductSize.Small), 
                new Product(ProductColor.Yellow, ProductSize.Small), 
                new Product(ProductColor.Yellow, ProductSize.Medium), 
                new Product(ProductColor.Red, ProductSize.Large), 
                new Product(ProductColor.Blue, ProductSize.ReallyBig)
            };
        }
    }
}
