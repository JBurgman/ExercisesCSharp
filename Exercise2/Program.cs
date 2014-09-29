using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fields
            float a = 1F;
            float b = 0.1F;
            Console.WriteLine(a - b * 10);

            decimal c = 1M;
            decimal d = 0.1M;
            Console.WriteLine(c - d * 10);

            Console.ReadLine();
        }
    }
}
