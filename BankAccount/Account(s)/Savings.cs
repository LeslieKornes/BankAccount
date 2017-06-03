using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Savings : Account  //derived class
    {
        public Savings(decimal balance, double clientID) : base(balance, clientID)
        {
            Type = "Savings";
        }
    }
}
