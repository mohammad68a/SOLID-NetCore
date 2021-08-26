using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ecommerce.Model
{
    class UsaTax : ITax
    {
        public string State { get; set; }
        public decimal Percentage { get; set; }

        public decimal GetAmount(decimal amount)
        {
            return amount * Percentage / 100;
        }
    }
}
