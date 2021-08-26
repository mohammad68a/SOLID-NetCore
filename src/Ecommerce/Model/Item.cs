using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Model
{
    public class Item
    {
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public Item(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }
    }
}
