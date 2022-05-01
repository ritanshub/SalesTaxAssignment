using SalesTaxAssignment.ShoppringCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTaxAssignment.ShoppingCart
{
    class Cart
    {
        public IList<Item> CartItems { get; set; }

        public decimal TotalTax { get { return CartItems.Sum(x => x.Tax); } }

        public decimal TotalCost { get { return CartItems.Sum(x => x.Cost); } }
    }
}
