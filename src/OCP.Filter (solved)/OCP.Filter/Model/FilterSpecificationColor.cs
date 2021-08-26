using System;
using System.Collections.Generic;
using OCP.Filter.Model;

namespace OCP.Filter.Model
{
    class FilterSpecificationColor : IFilterSpecification
    {
        private readonly ProductColor productColor;

        public FilterSpecificationColor(ProductColor productColor)
        {
            this.productColor = productColor;
        }

        public IEnumerable<Product> Filter(IList<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Color == productColor) yield return product;
            }
        }
    }
}