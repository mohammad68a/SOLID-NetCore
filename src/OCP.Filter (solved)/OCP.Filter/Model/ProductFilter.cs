using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.Filter.Model
{
    class ProductFilter
    {
        public IEnumerable<Product> By(IList<Product> products, IFilterSpecification filterSpecification)
        {
            return filterSpecification.Filter(products);
        }
    }

}
