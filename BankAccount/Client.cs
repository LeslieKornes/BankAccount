using System.Collections.Generic;

namespace BankAccount
{
     public class Client       
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Id { get; set; }
        public List<Account> Accounts { get; set; }

        public Client(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = 392457;        
        }
    }
}
