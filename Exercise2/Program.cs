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
            Console.Write("Name:");
            var name = Console.ReadLine();

            Console.Write("Work:");
            var work = Console.ReadLine();

            Console.Write("Age:");
            var age = Console.ReadLine();

            Console.Write("Jobtitle:");
            var jobtitle = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("You are {0} years old and work at {1}, where {2} is your title.",age,work,jobtitle);



            Console.ReadLine();
        }
    }
}
