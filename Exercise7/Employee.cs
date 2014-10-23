using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    /// <summary>
    /// A class which represent an Employee.
    /// </summary>
    public class Employee
    {
        // Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string SSN { get; private set; }
        public string Wage { get; private set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string Adress { get; set; }

        // Default constructor
        public Employee() { }

        // Overloaded constructors

        public Employee(string ssn)
        {
            SSN = ssn;
        }
        public Employee(string firstName, string lastName, string ssn, string wage)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
            Wage = wage;
        }

        // Methods
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", FirstName, LastName, SSN, Wage);
        }

    }
}
