using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        // Make the registry
        static Registry registry = new Registry();

        // Make a logger
        static Logger log = new Logger();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                // Print menu
                MenuPrint();

                // Make a choice
                MakeChoice();

                Console.ReadKey();
            }
        }

        private static void MakeChoice()
        {
            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        AddEmployee();
                        break;
                    }
                case 2:
                    {
                        RemoveEmployee();
                        break;
                    }
                case 3:
                    {
                        PrintRegistry();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Good bye!");
                        Environment.Exit(1);
                        break;
                    }

                default:
                    break;
            }
        }

        private static void PrintRegistry()
        {
            foreach (var item in registry.Employees)
            {
                Console.WriteLine(item);
            }

            // Print out log
            foreach (var item in log.LogPosts)
            {
                Console.WriteLine(item);
            }
        }

        private static void RemoveEmployee()
        {
            Console.Write("SSN");
            var ssn = Console.ReadLine();

            
            foreach (var item in registry.Employees)
            {
                if (item.SSN.Equals(ssn))
                {
                    registry.Employees.Remove(item);
                     //// Add to log post
                    log.Log(String.Format("Employee {0} removed from registry.",item.FirstName));
                    break;
                }
                
            }

            
           
        }

        private static void AddEmployee()
        {
            Console.Write("First name:");
            var firstName = Console.ReadLine();

            Console.Write("Last name:");
            var lastName = Console.ReadLine();

            Console.Write("SSN:");
            var ssn = Console.ReadLine();

            Console.Write("Wage:");
            var wage = Console.ReadLine();

            // Add a new employee to the registry
            var newEmployee = new Employee(firstName,lastName,ssn,wage);
            var employeeList = registry.Employees;
            employeeList.Add(newEmployee);

            // Add to log post
            log.Log(String.Format("New Employee, {0} added to registry.",newEmployee.FirstName));

        }

        private static void MenuPrint()
        {
            // Print the menu
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("1. Add employee");
            stringBuilder.AppendLine("2. Remove employee");
            stringBuilder.AppendLine("3. Print entire registry");
            stringBuilder.AppendLine("4. Exit");
            stringBuilder.AppendLine("Enter choice:");

            Console.WriteLine(stringBuilder);


        }
    }
}
