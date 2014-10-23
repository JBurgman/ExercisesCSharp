using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Account
    {
       
        // Field
        private decimal balance;

        // Properties
        public decimal Balance { 
            get { return balance; }
            private set { balance = value; }
        }  
  
        // Methods
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }

    }
}
