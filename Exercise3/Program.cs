using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        //Fields
        private static decimal amount;
        private static decimal tax;


        /// <summary>
        /// // This is the main entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            Console.Write("Enter the product name:");
            var productName = Console.ReadLine();

            Console.Write("Price per unit:");
            var pricePerUnit = Console.ReadLine();

            Console.Write("Quantity bought:");
            var quantity = Console.ReadLine();

            Console.Write("Food item? (y/n):");
            var isItem = Console.ReadLine();

            amount = decimal.Parse(pricePerUnit) * int.Parse(quantity);

            if (isItem == "y" || isItem == "Y")
                tax = 0.10M;
            else
                tax = 0.25M;

            PrintReciept(productName);

            //Console.ReadKey(); Instead press CTRL+F5
        }
        /// <summary>
        /// Method  for print the reciept to the console.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="tax"></param>
        /// <param name="productName"></param>
        private static void PrintReciept(string productName)
        {
            Console.WriteLine("\n\n--- RECEIPT ---");
            Console.WriteLine("Product:{0}", productName);
            Console.WriteLine("Total amount to pay, excluding tax:{0:c}", amount);
            Console.WriteLine("Total amount to pay, including tax:{0:c}", tax * amount);
            Console.WriteLine("Of which is tax:{0:c}", tax * amount);
            Console.WriteLine("---------------\n");
        }

    }
}
