using System.Collections.Generic;

namespace BankAccount
{
     public class Client        //I wanted to make a client class that can have different kinds of accounts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double ID { get; set; }
        public List<Account> Accounts { get; set; } //This list will be populated in main with the types of accounts this client has

        public Client(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = 392457;        //hardcoding the clientID here
        }
    }
}
