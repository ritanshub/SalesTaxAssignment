using System;
using System.Collections.Generic;
using System.Text;
using SalesTaxAssignment.Products;

namespace SalesTaxAssignment.Tax
{
    abstract class SalesTax
    {
        abstract public bool IsApplicable(Product item);
        abstract public decimal Rate { get; }

        public decimal Calculate(Product item)
        {
            if (IsApplicable(item))
            {
                //sales tax are that for a tax rate of n%, a shelf price of p contains (np/100)
                var tax = (item.ShelfPrice * Rate) / 100;
                tax = Utils.roundOffTax(tax);

                return tax;
            }

            return 0;
        }
    }
}
