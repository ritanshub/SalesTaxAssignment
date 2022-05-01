using System;

namespace SalesTaxAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = new[]
       {
            "1 book at 12.49",
            "1 music CD at 14.99",
            "1 chocolate bar at 0.85"
        };     

            TextInput.Process(input1);

            Console.ReadLine();
   
        }
    }
}
