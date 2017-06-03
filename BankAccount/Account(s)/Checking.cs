using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Checking : Account     //derived class
    {
        public Checking(decimal balance, double clientID) : base(balance, clientID)
        {
            Type = "Checking";
        }
    }
}
