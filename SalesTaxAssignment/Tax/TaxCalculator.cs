using SalesTaxAssignment.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTaxAssignment.Tax
{
    class TaxCalculator
    {
        private SalesTax[] _Taxes = new SalesTax[] { new BasicSalesTax(), new ImportedDutySalesTax() };

        public void Calculate(Cart shoppringCart)
        {
            foreach (var cartItem in shoppringCart.CartItems)
            {
                cartItem.Tax = _Taxes.Sum(x => x.Calculate(cartItem.Product));
            }
        }
    }
}
