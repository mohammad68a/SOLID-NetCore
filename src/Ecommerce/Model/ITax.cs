using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Model
{
    public interface ITax
    {
        decimal GetAmount(decimal amount);
    }
}
