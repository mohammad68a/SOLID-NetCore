using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Model
{
    public class Order
    {
        private IList<Item> items = new List<Item>();

        public IEnumerable<Item> Items
        {
            get { return items; }
        }

        public Discount Discount { get; set; }
        public ITax Tax { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public Order ()
        {
            Discount = new Discount(0,0,true);
            Tax = new NullTax();
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public decimal GetSubtotal()
        {
            decimal total = 0;
            foreach (Item item in Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }

        internal decimal GetTotal()
        {
            return GetSubtotal() - Discount.GetAmount(GetSubtotal()) + Tax.GetAmount(GetSubtotal());
        }
    }
}
