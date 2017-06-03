using System;

namespace BankAccount
{
    public abstract class Account       //This base class is abstract because it is never to be instantiated itself
    {                                       
        public double AccountNumber { get; set; }   //Property shortcuts
        public decimal Balance { get; set; }
        public double ClientID { get; set; }
        public string Type { get; set; }

        public Account(decimal balance, double clientID)    //Base constructor
        {
            Balance = balance;
            ClientID = clientID;
        }

        public int Deposit(decimal amount) //this is the actual deposit method
        {
            Balance += amount;
            return new Random().Next(6000, 7000);  //assigning a random number for a transactionID. 
        }

        public int Withdrawal(decimal amount)   //this is the actual withdrawal method
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("That is an invalid transaction. Your balance must stay above $0.00");
            }
            else
            {
                Balance -= amount;
            }
            return new Random().Next(2000, 3000);
        }
    }
}
