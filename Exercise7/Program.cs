using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Kalle", "Anka", "551011-0123", "5000 kr/v");
            Console.WriteLine(employee.ToString());

            var fullName = employee.FullName;
            Console.WriteLine(fullName);

        }
    }
}
