using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.Filter.Model
{
    interface IFilterSpecification
    {
        IEnumerable<Product> Filter(IList<Product> products);
    }
}
