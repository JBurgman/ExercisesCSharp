using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Registry
    {
        // Properties
        public List<Employee> Employees{get;set;}

        // Constructor
        public Registry() { Employees = new List<Employee>(); }

        // Methods
        void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        
    }
}
