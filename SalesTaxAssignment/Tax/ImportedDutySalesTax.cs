using SalesTaxAssignment.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxAssignment.Tax
{
    class ImportedDutySalesTax : SalesTax
    {
        public override bool IsApplicable(Product item)
        {
            return item.IsImported;
        }

        public override decimal Rate { get { return 5.00M; } }
    }
}
