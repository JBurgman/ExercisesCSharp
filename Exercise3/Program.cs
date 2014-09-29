using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        /// <summary>
        /// // This is the main entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.Write("What is your age?");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, {0}!", name);
            Console.ReadKey();
        }
    }
}
