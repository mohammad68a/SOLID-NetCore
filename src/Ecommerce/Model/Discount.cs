using System;
using NUnit.Framework;

namespace Ecommerce.Model
{
    public class Discount
    {
        public int Number { get; private set; }
        public decimal Percentage { get; private set; }
        public bool Used { get; private set; }

        private decimal appliedPercentage;

        public Discount(int number)
        {
            Number = number;
            Percentage = 0;
            Used = true;
        }

        public Discount(int number, decimal percentage, bool used)
        {
            Number = number;
            Percentage = percentage;
            Used = used;
        }

        public void Apply()
        {
            if(!Used)
            {
                appliedPercentage = Percentage;
                Used = true;
            }
        }

        public decimal GetAmount(decimal amount)
        {
            return amount * appliedPercentage;
        }
    }
}
