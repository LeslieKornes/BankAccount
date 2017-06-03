using System;

namespace BankAccount
{
    public abstract class Account    
    {                                       
        public double AccountNumber { get; set; }   
        public decimal Balance { get; set; }
        public double ClientId { get; set; }
        public string Type { get; set; }

        public Account(decimal balance, double clientId)    
        {
            Balance = balance;
            ClientId = clientId;
        }
        public int Deposit(decimal amount) 
        {
            Balance += amount;
            return new Random().Next(6000, 7000); 
        }
        public int Withdrawal(decimal amount)   
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
