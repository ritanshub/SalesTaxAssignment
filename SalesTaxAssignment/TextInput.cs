using SalesTaxAssignment.Tax;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxAssignment
{
    class TextInput
    {
        public static void Process(string[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var shoppringCart = ItemParser.Parse(input);

            var taxCalculator = new TaxCalculator();
            taxCalculator.Calculate(shoppringCart);

            //Discounting can be applied here!

            ShopingCartPrinter.Print(shoppringCart);
        }
    }
}
