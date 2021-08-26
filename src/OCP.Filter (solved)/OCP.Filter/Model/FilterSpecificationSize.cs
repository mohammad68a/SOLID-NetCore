using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.Filter.Model
{
    class FilterSpecificationSize : IFilterSpecification
    {
        private readonly ProductSize productSize;

        public FilterSpecificationSize(ProductSize productSize)
        {
            this.productSize = productSize;
        }

        public IEnumerable<Product> Filter(IList<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Size == productSize) yield return product;
            }
        }
    }
}
