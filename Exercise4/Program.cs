using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input from user
            Console.Write("Enter a number:");
            var number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Number must be positive!");
            }
            else
            {

                // Calculate and present the result
                var result = Calculate(number);

                DisplayNumbers(number, result);
            }
        }

        private static int Calculate(int number)
        {
            int summa = 0;
            while (number>0)
            {
                summa += number;
                number--;
            }

            return summa;
        }

        private static void DisplayNumbers(int number, int summa)
        {
           

                for (int i = 1; i <= number; i++)
                {
                    if (i == number)
                    {
                        Console.Write("{0}=", i);
                    }
                    else
                    { Console.Write("{0}+", i); }

                }
                Console.WriteLine("{0}", summa);
            
           
        }
    }
}
