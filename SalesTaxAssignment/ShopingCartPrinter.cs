using SalesTaxAssignment.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxAssignment
{
    class ShopingCartPrinter
    {
        public static void Print(Cart shoppringCart)
        {
            
            foreach (var cartItem in shoppringCart.CartItems)
            {
                Console.WriteLine(cartItem.ToString());
            }

            //print Sales => Taxes: 1.50
            Console.WriteLine("Taxes: {0:N2}", shoppringCart.TotalTax);

            //print => Total: 29.83
            Console.WriteLine("Total: {0:N2}", shoppringCart.TotalCost);
        }
    }
}
