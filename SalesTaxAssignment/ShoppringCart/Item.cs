﻿using SalesTaxAssignment.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxAssignment.ShoppringCart
{
    class Item
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal Tax { get; set; }

        public decimal Cost { get { return Quantity * (Tax + Product.ShelfPrice); } }

        public override string ToString()
        {
            return string.Format("{0} {1} : {2:N2}", Quantity, Product.Name, Cost);
        }
    }
}