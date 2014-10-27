using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make the registry
            var registry = new Registry();

            // Add a new employee to the registry
            var newEmployee = new Employee("Kalle", "Anka", "550123-0123", "5000 kr/v");

            var employeeList = registry.Employees;

            employeeList.Add(newEmployee);

           

            // Add another employee
            var anotherEmployee=new Employee("Kajsa", "Anka", "551011-7890","6000 kr/v");

            employeeList.Add(anotherEmployee);

            foreach (var item in employeeList)
            {
                Console.WriteLine(item);
            }

            // Remove employee
            employeeList.Remove(newEmployee);

            Console.WriteLine();
            foreach (var item in employeeList)
            {
                Console.WriteLine(item);
            }

            

           

        }
    }
}
