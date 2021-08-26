using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Model;

namespace Ecommerce.Services
{
    public interface IDiscountService
    {
        Discount GetDiscount(int number);
        void ApplyDiscount(int number);
    }
}
