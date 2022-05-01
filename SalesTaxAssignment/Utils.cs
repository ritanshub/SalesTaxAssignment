using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxAssignment
{
    class Utils
    {
        public static decimal roundOffTax(decimal number)
        {
            return Math.Ceiling(number * 20) / 20;
        }

        public static decimal roundOffAmount(decimal number)
        {
            return Math.Round(number * 100) / 100;
        }
    }
}
