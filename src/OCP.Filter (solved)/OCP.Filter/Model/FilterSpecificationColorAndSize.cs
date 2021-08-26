using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.Filter.Model
{
    class FilterSpecificationColorAndSize : IFilterSpecification
    {
        private readonly ProductColor productColor;
        private readonly ProductSize productSize;

        public FilterSpecificationColorAndSize(ProductColor productColor, ProductSize productSize)
        {
            this.productColor = productColor;
            this.productSize = productSize;
        }

        public IEnumerable<Product> Filter(IList<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Color == productColor && product.Size == productSize) yield return product;
            }
        }
    }
}
