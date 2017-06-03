using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Reserve : Account      //derived class
    {
        public Reserve(decimal balance, double clientID) : base(balance, clientID)
        {
            Type = "Reserve";
        }
    }
}
