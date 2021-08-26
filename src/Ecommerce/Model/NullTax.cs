using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ecommerce.Model
{
    class NullTax : ITax
    {
        public decimal GetAmount(decimal amount)
        {
            return 0;
        }
    }
}
